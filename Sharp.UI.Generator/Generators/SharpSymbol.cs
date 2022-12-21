﻿//
// MIT License
// Copyright Pawel Krzywdzinski
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Sharp.UI.Generator
{
	public partial class SharpSymbol
	{
        public const string SharpObjectAttributeString = "SharpObject";
        public const string BindablePropertiesAttributeString = "BindableProperties";
        public const string AttachedPropertiesAttributeString = "AttachedProperties";
        public const string AttachedInterfacesAttributeString = "AttachedInterfaces";
        public const string ContentPropertyAttributeString = "ContentProperty";
        public const string AttachedNameAttributeString = "AttachedName";
        public const string PropertyCallbackAttributeString = "PropertyCallbacks";
        public const string DefaultValueAttributeString = "DefaultValue";

        public const string CompatibilityString = "Compatibility";

        class SharpObjectAttribParams
        {
            public const int WrappedType = 0;
            public const int ConstructorWithProperties = 1;
            public const int ContainerPopertyName = 2;
        }

        private StringBuilder builder;

        INamedTypeSymbol mainSymbol { get; set; }

        // attributes
        AttributeData sharpAttribute;
        AttributeData attachedInterfacesAttribute;

        // [SharpObject] parameters
        public INamedTypeSymbol WrappedType { get; private set; }
        List<string> constructorWithProperties = null;
        string containerPropertyName = null;

        // helpers
        public bool IsSharpUIType => sharpAttribute != null;
        public bool IsWrappedType => WrappedType != null;
        public bool IsUserDefiniedType => IsSharpUIType && !mainSymbol.ContainingNamespace.ToDisplayString().Equals("Sharp.UI");

        // not generate list
        List<string> notGenerateList = null;

        // class generation
        bool generateAdditionalConstructors = false;
        bool generateNoParamConstructor = false;
        bool singleItemContainer = false;
        string containerOfTypeName = null;
        string nameSpaceString;

        // extensions
        private string typeConformanceName;
        private INamedTypeSymbol extensionType => mainSymbol.IsStatic && IsWrappedType ? WrappedType : mainSymbol;

        public SharpSymbol(INamedTypeSymbol symbol)
		{
            mainSymbol = symbol;

            // get attributes
            sharpAttribute = GetSharpAttributeData(mainSymbol);
            attachedInterfacesAttribute = GetAttachedInterfacesAttributeData();

            WrappedType = GetWrappedType(sharpAttribute);

            nameSpaceString = IsUserDefiniedType ? mainSymbol.ContainingNamespace.ToDisplayString() : "Sharp.UI";
            typeConformanceName = IsSharpUIType && IsUserDefiniedType && !mainSymbol.IsStatic ? symbol.ToDisplayString() : $"Sharp.UI.I{GetNormalizedName()}";

            SetupContainerIfNeeded();
            SetupConstructorsGeneration();
          
            this.notGenerateList = new List<string>();
            notGenerateList.Add("this[]");
            notGenerateList.Add("Handler");
            notGenerateList.Add("LogicalChildren");
        }

        void SetupContainerIfNeeded()
        {
            if (IsWrappedType)
            {
                this.containerPropertyName = (string)(sharpAttribute.ConstructorArguments[SharpObjectAttribParams.ContainerPopertyName].Value);

                var isContainerThis = Helpers.IsGenericIList(WrappedType, out var containerType);
                if (isContainerThis && WrappedType.IsSealed)
                {
                    this.containerOfTypeName = containerType;
                    this.containerPropertyName = "this";
                    this.singleItemContainer = false;
                }
                else if (!isContainerThis)
                {
                    // if is null try to find
                    if (string.IsNullOrEmpty(this.containerPropertyName))
                    {
                        var propertyName = FindContentPropertyName();
                        if (propertyName != null && string.IsNullOrEmpty(this.containerPropertyName))
                            this.containerPropertyName = propertyName;
                    }

                    if (!string.IsNullOrEmpty(this.containerPropertyName))
                    {
                        IPropertySymbol propertySymbol = FindPropertySymbolWithName(this.containerPropertyName);

                        if (propertySymbol == null) throw new Exception($"No content property for: {WrappedType.Name}");

                        var mauiContainerType = (INamedTypeSymbol)((propertySymbol).Type);
                        if (Helpers.IsGenericIList(mauiContainerType, out var ofTypeName))
                        {
                            this.containerOfTypeName = ofTypeName;
                            this.singleItemContainer = false;
                        }
                        else
                        {
                            this.containerOfTypeName = mauiContainerType.ToDisplayString();
                            this.singleItemContainer = true;
                        }
                    }
                }
            }
        }

        void SetupConstructorsGeneration()
        {
            if (sharpAttribute != null)
            {
                var constructorWithPropertiesValues = sharpAttribute.ConstructorArguments[SharpObjectAttribParams.ConstructorWithProperties].Values;
                if (!constructorWithPropertiesValues.IsDefaultOrEmpty)
                    this.constructorWithProperties = constructorWithPropertiesValues.Select(e => (string)e.Value).ToList();
                else
                    this.constructorWithProperties = new List<string>();
            }

            this.generateNoParamConstructor = true;
            if (mainSymbol.Constructors.FirstOrDefault(e => e.Parameters.Count() == 0 && !e.IsImplicitlyDeclared) != null)
                this.generateNoParamConstructor = false;

            if (IsWrappedType)
            {
                if (WrappedType.Constructors.FirstOrDefault(e => e.Parameters.Count() == 0) == null)
                    this.generateNoParamConstructor = false;
            }

            this.generateAdditionalConstructors =
                    mainSymbol.Constructors.FirstOrDefault(e => !e.IsImplicitlyDeclared) != null ||
                    this.generateNoParamConstructor;
        }

        // ------ normalized name ------

        public static string GetNormalizedName(INamedTypeSymbol type)
        {
            var prefix = type.ContainingNamespace.ToDisplayString().Contains(CompatibilityString) ? CompatibilityString : "";
            var name = type.IsStatic ? type.Name.Replace("Extension", "") : type.Name;
            var tail = type.IsGenericType ? $"{type.TypeArguments.FirstOrDefault().Name}" : "";
            return $"{prefix}{name}{tail}";
        }

        public string GetNormalizedName()
        {
            var type = IsWrappedType ? WrappedType : mainSymbol;
            return GetNormalizedName(type);
        }

        public string GetNormalizedExtensionName()
        {
            var tail = IsSharpUIType ? (IsUserDefiniedType ? "GeneratedUserExtension" : "GeneratedSharpObjectExtension") : "GeneratedExtension";
            return $"{GetNormalizedName(mainSymbol)}{tail}";
        }

        // ------ helpers ------

        public static AttributeData GetSharpAttributeData(INamedTypeSymbol symbol)
        {
            var attributes = symbol.GetAttributes();
            return attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains(SharpObjectAttributeString));
        }

        public static INamedTypeSymbol GetWrappedType(AttributeData attributeData)
        {
            if (attributeData == null) return null;
            return attributeData.ConstructorArguments[SharpObjectAttribParams.WrappedType].Value as INamedTypeSymbol;
        }

        AttributeData GetAttachedInterfacesAttributeData()
        {
            var attributes = mainSymbol.GetAttributes();
            return attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains(AttachedInterfacesAttributeString));
        }

        string GetAttachedName(ISymbol symbol)
        {
            var attributes = symbol.GetAttributes();
            var attributeData = attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains(AttachedNameAttributeString));
            if (attributeData != null) return (string)attributeData.ConstructorArguments[0].Value;
            return null;
        }

        Dictionary<string, string> GetPropertyCallbacks(ISymbol symbol)
        {
            var data = new Dictionary<string, string>();
            var attributes = symbol.GetAttributes();
            var attributeData = attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains(PropertyCallbackAttributeString));
            if (attributeData != null)
            {
                var arguments = attributeData.ConstructorArguments;
                if (arguments[0].Value != null) data["propertyChanged"] = (string)arguments[0].Value;
                if (arguments[1].Value != null) data["validateValue"] = (string)arguments[1].Value;
                if (arguments[2].Value != null) data["coerceValue"] = (string)arguments[2].Value;
                if (arguments[3].Value != null) data["defaultValueCreator"] = (string)arguments[3].Value;
                if (data.Count() == 0) throw new ArgumentException($"PropertyCallback attribute must have minmium one attribute defined, symbol: {symbol.ToDisplayString()}");
            }
            return data;
        }

        string GetDefaultValueString(ISymbol symbol, string typeName)
        {
            var attributes = symbol.GetAttributes();
            var attributeData = attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains(DefaultValueAttributeString));
            if (attributeData != null)
            {
                
                var value =  attributeData.ConstructorArguments[0].Value.ToString();
                if (typeName.Equals("string")) value = $"\"{value}\"";
                if (typeName.Equals("double") || typeName.Equals("float")) value = value.Replace(",", ".");
                return value;
            }
            return null;
        }

        string FindContentPropertyName()
        {
            AttributeData attributeData = null;
            Helpers.LoopDownToObject(this.WrappedType, type =>
            {
                attributeData = type.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains(ContentPropertyAttributeString));
                return attributeData != null;
            });
            if (attributeData != null)
            {
                return (string)attributeData.ConstructorArguments[0].Value;
            }
            return null;
        }

        IPropertySymbol FindPropertySymbolWithName(string propertyName)
        {
            IPropertySymbol propertySymbol = null;
            Helpers.LoopDownToObject(this.WrappedType, type =>
            {
                propertySymbol = (IPropertySymbol)(type.GetMembers(propertyName).FirstOrDefault());
                return propertySymbol != null;
            });
            return propertySymbol;
        }
    }
}