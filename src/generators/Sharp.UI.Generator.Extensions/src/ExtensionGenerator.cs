﻿//
// MIT License
// Copyright Pawel Krzywdzinski
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Sharp.UI.Generator.Extensions
{
    public class ExtensionGenerator
    {
        readonly GeneratorExecutionContext context;
        readonly INamedTypeSymbol mainSymbol;
        readonly bool isBindableObject;

        StringBuilder builder;
        bool isExtensionMethodsGenerated;

        public ExtensionGenerator(GeneratorExecutionContext context, INamedTypeSymbol symbol)
        {
            this.context = context;
            this.mainSymbol = symbol;
            this.isBindableObject = Helpers.IsBindable(mainSymbol);
        }

        public void Build()
        {
            isExtensionMethodsGenerated = false;
            builder = new StringBuilder();
            builder.AppendLine("//");
            builder.AppendLine("// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder");
            builder.AppendLine("//");
            builder.AppendLine();

            builder.AppendLine("#nullable enable");
            builder.AppendLine("#pragma warning disable CS8601");
            builder.AppendLine();

            GenerateExtensionNameSpace();

            builder.AppendLine();
            builder.AppendLine("#pragma warning restore CS8601");
            builder.AppendLine("#nullable restore");


            if (isExtensionMethodsGenerated)
            {
                var tail = mainSymbol.ContainingNamespace.ToDisplayString().StartsWith("Microsoft.Maui") ? "" : ".extension";
                context.AddSource($"{mainSymbol.ContainingNamespace.ToDisplayString()}.{Helpers.GetNormalizedFileName(mainSymbol)}{tail}.g.cs", builder.ToString());
            }
        }

        void GenerateExtensionNameSpace()
        {
            builder.Append($@"
namespace {(mainSymbol.ContainingNamespace.ToDisplayString().StartsWith("Microsoft.Maui") ? "Sharp.UI" : mainSymbol.ContainingNamespace.ToDisplayString())}
{{
    {Shared.GetUsingString(mainSymbol)}using Sharp.UI.Internal;

    public static partial class {Helpers.GetNormalizedClassName(mainSymbol)}Extension
    {{");
            GenerateClassExtensionBody();
            builder.AppendLine($@"
    }}
}}");
        }

        List<string> extensionBindablePropertiesGenerated;

        void GenerateClassExtensionBody()
        {
            extensionBindablePropertiesGenerated = new List<string>();
            var bindableProperties = mainSymbol
                    .GetMembers()
                    .Where(e => e.IsStatic && e.Name.EndsWith("Property") && e.DeclaredAccessibility == Accessibility.Public).ToList();

            extensionBindablePropertiesGenerated.Clear();
            foreach (var prop in bindableProperties)
            {
                var name = prop.Name.Substring(0, prop.Name.Length - "Property".Length);
                extensionBindablePropertiesGenerated.Add(name);
            }

            var properties = mainSymbol
                .GetMembers()
                .Where(e => e.Kind == SymbolKind.Property && e.DeclaredAccessibility == Accessibility.Public && !e.IsStatic);

            var events = mainSymbol
                .GetMembers()
                .Where(e => e.Kind == SymbolKind.Event && e.DeclaredAccessibility == Accessibility.Public && !e.IsStatic);

            foreach (var prop in properties)
                GenerateExtensionMethod(prop as IPropertySymbol);

            foreach (var @event in events)
                GenerateEventMethod(@event);

            GenerateBindablePropertiesExtension();
        }


        class PropertyInfo
        {
            public INamedTypeSymbol MainSymbol { get; set; }
            public IPropertySymbol PropertySymbol { get; set; }
            public List<string> BindableProperties { get; set; }
            public bool IsBindableObject { get; set; }
            public bool IsBindableProperty { get; set; }

            public string propertyName;
            public string bindablePropertyName;
            public string accessedWith;
            public string propertyTypeName;
            public string camelCaseName;
            public string symbolTypeName;
            public string valueAssignmentString;
            public string valueBuilderAssignmentString;
            public string fluentStylingCheckString;

            public void Build()
            {
                this.PropertySymbol = PropertySymbol;

                propertyName = PropertySymbol.Name.Split(new[] { "." }, StringSplitOptions.None).Last();
                propertyName = propertyName.Equals("class", StringComparison.Ordinal) ? "@class" : propertyName;

                if (BindableProperties != null) IsBindableProperty = BindableProperties.Contains(propertyName);

                accessedWith = PropertySymbol.IsStatic ? $"{MainSymbol.ToDisplayString()}" : "obj";
                propertyTypeName = PropertySymbol.Type.ToDisplayString();
                camelCaseName = Helpers.CamelCase(propertyName);
                bindablePropertyName = $"{MainSymbol.ToDisplayString()}.{propertyName}Property";
                symbolTypeName = $"{MainSymbol.ToDisplayString()}";

                valueAssignmentString = IsBindableProperty  ?
                    $@"obj.SetValueOrSetter({bindablePropertyName}, {camelCaseName});" :
                    $"{accessedWith}.{propertyName} = {camelCaseName};";

                valueBuilderAssignmentString = IsBindableProperty ?
                    $@"if (builder.ValueIsSet()) obj.SetValueOrSetter({bindablePropertyName}, builder.GetValue());" :
                    $@"if (builder.ValueIsSet()) obj.{propertyName} = builder.GetValue();";

            //    fluentStylingCheckString =  IsBindableObject && !IsBindableProperty ?
            //$@"bool isStyling = (bool)obj.GetValue(FluentStyling.IsStyling);
            //if (isStyling) throw new ArgumentException(""Fluent styling not available for property {propertyName}"");
            //" : "";

            }
        }

        bool ExistInBaseClasses(string propertyName, bool getterAndSetter)
        {
            var existInBaseClasses = false;
            Helpers.LoopDownToObject(mainSymbol.BaseType, type =>
            {
                existInBaseClasses = (type
                            .GetMembers()
                            .FirstOrDefault(e =>
                                e.Kind == SymbolKind.Property &&
                                e.DeclaredAccessibility == Accessibility.Public &&
                                (((IPropertySymbol)e).SetMethod != null || !getterAndSetter) &&
                                e.Name.Equals(propertyName, StringComparison.Ordinal)) != null);

                return existInBaseClasses;
            });
            return existInBaseClasses;
        }

        // --------------------------------------------------
        // ----- bindable from interface fluent methods -----    
        // --------------------------------------------------

        void GenerateBindablePropertiesExtension()
        {
            // generate using bindable interface
            var interfaces = mainSymbol
                .Interfaces
                .Where(e => e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Equals(Shared.BindablePropertiesAttributeString, StringComparison.Ordinal)) != null);

            foreach (var inter in interfaces)
            {
                var properties = inter
                    .GetMembers()
                    .Where(e => e.Kind == SymbolKind.Property);

                foreach (var prop in properties)
                {
                    var propertySymbol = (IPropertySymbol)prop;
                    var fullPropertyName = $"{mainSymbol.ToDisplayString()}.{prop.Name}";
                    GenerateExtensionMethodForBindable(propertySymbol);
                }
            }
        }

        void GenerateExtensionMethodForBindable(IPropertySymbol propertySymbol)
        {
            var info = new PropertyInfo
            {
                MainSymbol = mainSymbol,
                PropertySymbol = propertySymbol,
                IsBindableProperty = true,
                IsBindableObject = isBindableObject
            };
            info.Build();

            if (!Shared.NotGenerateList.Contains(info.propertyName))
            {
                GenerateExtensionMethod_Value(info);
                GenerateExtensionMethod_ValueBuilder(info);
                GenerateExtensionMethod_BindingBuilder(info);

                if (info.propertyTypeName.Contains("DataTemplate"))
                    GenerateExtensionMethod_DataTemplate(info);
            }
        }

        // -----------------------------------
        // ----- property fluent methods -----    
        // -----------------------------------

        void GenerateExtensionMethod(IPropertySymbol property)
        {
            var info = new PropertyInfo
            {
                MainSymbol = mainSymbol,
                PropertySymbol = property,
                BindableProperties = extensionBindablePropertiesGenerated,
                IsBindableObject = isBindableObject
            };
            info.Build();

            var propertyType = info.PropertySymbol.Type as INamedTypeSymbol;
            var isGenericIList = Helpers.IsGenericIList(propertyType, out var elementType);

            if (!Shared.NotGenerateList.Contains(info.propertyName))
            {
                if (!isGenericIList &&
                    info.PropertySymbol.SetMethod != null &&
                    info.PropertySymbol.SetMethod.DeclaredAccessibility == Accessibility.Public &&
                    !ExistInBaseClasses(info.propertyName, getterAndSetter: true))
                {
                    GenerateExtensionMethod_Value(info);
                    GenerateExtensionMethod_ValueBuilder(info);
                    if (info.IsBindableProperty)
                        GenerateExtensionMethod_BindingBuilder(info);

                    if (info.propertyTypeName.Contains("DataTemplate"))
                        GenerateExtensionMethod_DataTemplate(info);
                }
                else if (isGenericIList &&
                    info.PropertySymbol.GetMethod != null &&
                    info.PropertySymbol.GetMethod.DeclaredAccessibility == Accessibility.Public &&
                    !ExistInBaseClasses(info.propertyName, getterAndSetter: false))
                {
                    GenerateExtensionMethod_List(info, elementType.ToDisplayString());
                    if (info.IsBindableProperty)
                        GenerateExtensionMethod_BindingBuilder(info);
                }
            }
        }

        void GenerateExtensionMethod_Value(PropertyInfo info)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_Value_Sealed(info);
            else
                GenerateExtensionMethod_Value_Normal(info);
        }

        void GenerateExtensionMethod_Value_Sealed(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} obj,
            {info.propertyTypeName} {info.camelCaseName})
        {{
            {info.fluentStylingCheckString}{info.valueAssignmentString}
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_Value_Normal(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T {info.propertyName}<T>(this T obj,
            {info.propertyTypeName} {info.camelCaseName})
            where T : {info.symbolTypeName}
        {{
            {info.fluentStylingCheckString}{info.valueAssignmentString}
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_BindingBuilder(PropertyInfo info)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_BindingBuilder_Sealed(info);
            else
                GenerateExtensionMethod_BindingBuilder_Normal(info);
        }

        void GenerateExtensionMethod_BindingBuilder_Sealed(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} obj,
            System.Func<BindingBuilder<{info.propertyTypeName}>, BindingBuilder<{info.propertyTypeName}>> buidBinding)
        {{
            var builder = buidBinding(new BindingBuilder<{info.propertyTypeName}>(obj, {info.bindablePropertyName}));
            builder.BindProperty();
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_BindingBuilder_Normal(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T {info.propertyName}<T>(this T obj,
            System.Func<BindingBuilder<{info.propertyTypeName}>, BindingBuilder<{info.propertyTypeName}>> buidBinding)
            where T : {info.symbolTypeName}
        {{
            var builder = buidBinding(new BindingBuilder<{info.propertyTypeName}>(obj, {info.bindablePropertyName}));
            builder.BindProperty();
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_ValueBuilder(PropertyInfo info)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_ValueBuilder_Sealed(info);
            else
                GenerateExtensionMethod_ValueBuilder_Normal(info);
        }

        void GenerateExtensionMethod_ValueBuilder_Sealed(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} obj,
            System.Func<ValueBuilder<{info.propertyTypeName}>, ValueBuilder<{info.propertyTypeName}>> buidValue)
        {{
            {info.fluentStylingCheckString}var builder = buidValue(new ValueBuilder<{info.propertyTypeName}>());
            {info.valueBuilderAssignmentString}
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_ValueBuilder_Normal(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T {info.propertyName}<T>(this T obj,
            System.Func<ValueBuilder<{info.propertyTypeName}>, ValueBuilder<{info.propertyTypeName}>> buidValue)
            where T : {info.symbolTypeName}
        {{
            {info.fluentStylingCheckString}var builder = buidValue(new ValueBuilder<{info.propertyTypeName}>());
            {info.valueBuilderAssignmentString}
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_DataTemplate(PropertyInfo info)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_DataTemplate_Sealed(info);
            else
                GenerateExtensionMethod_DataTemplate_Normal(info);
        }

        void GenerateExtensionMethod_DataTemplate_Sealed(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}<T>(this {info.symbolTypeName} obj, System.Func<object> loadTemplate)
        {{
            {info.accessedWith}.{info.propertyName} = new DataTemplate(loadTemplate);
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_DataTemplate_Normal(PropertyInfo info)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T {info.propertyName}<T>(this T obj, System.Func<object> loadTemplate)
            where T : {info.symbolTypeName}
        {{
            {info.accessedWith}.{info.propertyName} = new DataTemplate(loadTemplate);
            return obj;
        }}
        ");
        }

        // -------------------------------
        // ----- list fluent methods -----    
        // -------------------------------

        void GenerateExtensionMethod_List(PropertyInfo info, string elementTypeName)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_List_Sealed(info, elementTypeName);
            else
                GenerateExtensionMethod_List_Normal(info, elementTypeName);
        }

        void GenerateExtensionMethod_List_Sealed(PropertyInfo info, string elementTypeName)
        {
            isExtensionMethodsGenerated = true;
            var tail = info.propertyTypeName.EndsWith("?") ? "?" : "";
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} obj,
            IList<{elementTypeName}> {info.camelCaseName})
        {{
            foreach (var item in {info.camelCaseName})
                {info.accessedWith}.{info.propertyName}{tail}.Add(item);
            return obj;
        }}

        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} obj,
            params {elementTypeName}[] {info.camelCaseName})
        {{
            foreach (var item in {info.camelCaseName})
                {info.accessedWith}.{info.propertyName}{tail}.Add(item);
            return obj;
        }}
        ");
        }

        void GenerateExtensionMethod_List_Normal(PropertyInfo info, string elementTypeName)
        {
            isExtensionMethodsGenerated = true;
            var tail = info.propertyTypeName.EndsWith("?") ? "?" : "";
            builder.Append($@"
        public static T {info.propertyName}<T>(this T obj,
            IList<{elementTypeName}> {info.camelCaseName})
            where T : {info.symbolTypeName}
        {{
            foreach (var item in {info.camelCaseName})
                {info.accessedWith}.{info.propertyName}{tail}.Add(item);
            return obj;
        }}

        public static T {info.propertyName}<T>(this T obj,
            params {elementTypeName}[] {info.camelCaseName})
            where T : {info.symbolTypeName}
        {{
            foreach (var item in {info.camelCaseName})
                {info.accessedWith}.{info.propertyName}{tail}.Add(item);
            return obj;
        }}
        ");
        }

        // --------------------------------
        // ----- event fluent methods -----    
        // --------------------------------

        void GenerateEventMethod(ISymbol @event)
        {
            var eventSymbol = (IEventSymbol)@event;
            var eventHandler = eventSymbol.AddMethod.Parameters.First();
            var eventHandlerType = ((INamedTypeSymbol)eventHandler.Type);

            var existInBases = false;
            Helpers.LoopDownToObject(mainSymbol.BaseType, type =>
            {
                existInBases = (type
                    .GetMembers()
                    .FirstOrDefault(e =>
                        e.Kind == SymbolKind.Event &&
                        e.DeclaredAccessibility == Accessibility.Public &&
                        e.Name.Equals(eventSymbol.Name, StringComparison.Ordinal)) != null);

                return existInBases;
            });

            if (!existInBases && !Shared.NotGenerateList.Contains(eventSymbol.Name))
            {
                if (mainSymbol.IsSealed)
                {
                    GenerateEventMethodHandler_Sealed(eventSymbol, eventHandlerType);
                    GenerateEventMethodNoArgs_Sealed(eventSymbol);
                }
                else
                {
                    GenerateEventMethodHandler_Normal(eventSymbol, eventHandlerType);
                    GenerateEventMethodNoArgs_Normal(eventSymbol);
                }
            }
        }

        void GenerateEventMethodHandler_Sealed(IEventSymbol eventSymbol, INamedTypeSymbol namedType)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {mainSymbol.ToDisplayString()} On{eventSymbol.Name}(this {mainSymbol.ToDisplayString()} obj, {namedType.ToDisplayString()} handler)
        {{
            obj.{eventSymbol.Name} += handler;
            return obj;
        }}
        ");
        }

        void GenerateEventMethodHandler_Normal(IEventSymbol eventSymbol, INamedTypeSymbol namedType)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T On{eventSymbol.Name}<T>(this T obj, {namedType.ToDisplayString()} handler)
            where T : {mainSymbol.ToDisplayString()}
        {{
            obj.{eventSymbol.Name} += handler;
            return obj;
        }}
        ");
        }

        void GenerateEventMethodNoArgs_Sealed(IEventSymbol eventSymbol)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static {mainSymbol.ToDisplayString()} On{eventSymbol.Name}(this {mainSymbol.ToDisplayString()} obj, System.Action<{mainSymbol.ToDisplayString()}> action)
        {{
            obj.{eventSymbol.Name} += (o, arg) => action(obj);
            return obj;
        }}
        ");
        }

        void GenerateEventMethodNoArgs_Normal(IEventSymbol eventSymbol)
        {
            isExtensionMethodsGenerated = true;
            builder.Append($@"
        public static T On{eventSymbol.Name}<T>(this T obj, System.Action<T> action)
            where T : {mainSymbol.ToDisplayString()}
        {{
            obj.{eventSymbol.Name} += (o, arg) => action(obj);
            return obj;
        }}
        ");
        }
    }
}

