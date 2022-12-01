﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace MauiWrapperGenerator;

public class WrapBuilder
{
    GeneratorExecutionContext context;
    List<string> interfaceNameList = new List<string>();

    public WrapBuilder(GeneratorExecutionContext context)
    {
        this.context = context;
    }

    //------ static

    public static string GetInterfaceName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $"{type.TypeArguments.FirstOrDefault().Name}" : "";
        var prefix = type.ContainingNamespace.ToDisplayString().Contains("Compatibility") ? "Compatibility" : "";
        return $"I{prefix}{type.Name}{tail}";
    }

    public static string CamelCase(string str)
    {
        var camelCaseName = $"{str.Substring(0, 1).ToLower()}{str.Substring(1)}";
        camelCaseName = camelCaseName.Equals("class") ? "@class" : camelCaseName;
        camelCaseName = camelCaseName.Equals("switch") ? "@switch" : camelCaseName;
        camelCaseName = camelCaseName.Equals("event") ? "@event" : camelCaseName;
        return camelCaseName;
    }

    //------

    private AttributeData GetAttributeData(INamedTypeSymbol symbol)
    {
        var attributes = symbol.GetAttributes();
        return attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains("MauiWrapper"));
    }

    private INamedTypeSymbol GetMauiType(AttributeData wrapperAttribute)
    {
        return (INamedTypeSymbol)wrapperAttribute.ConstructorArguments[0].Value;
    }

    private INamedTypeSymbol GetMauiType(INamedTypeSymbol symbol)
    {
        return GetMauiType(GetAttributeData(symbol));
    }

    public void Generate()
	{

        var wrappedSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
            .Where(e => e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains("MauiWrapper")) != null);

        foreach (var symbol in wrappedSymbols)
        {
            var typeSymbol = (INamedTypeSymbol)symbol;
            var wrapperAttribute = GetAttributeData(typeSymbol);
            var mauiType = GetMauiType(wrapperAttribute);

            this.Generate(typeSymbol, wrapperAttribute);
        }


        GenerateExtensions(wrappedSymbols);
        GenerateInterfaces(wrappedSymbols);
        GenerateGlobalUsings(wrappedSymbols);
    }

    void GenerateGlobalUsings(IEnumerable<ISymbol> symbols)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine();
        builder.AppendLine("global using VerticalStackLayout = Sharp.UI.VStack;");
        builder.AppendLine("global using HorizontalStackLayout = Sharp.UI.HStack;");
        builder.AppendLine();

        foreach (var symbol in symbols)
        {
            var mauiType = GetMauiType((INamedTypeSymbol)symbol);
            var sealedStr = mauiType.IsSealed ? "// sealed" : "";
            builder.AppendLine($@"global using {symbol.Name} = Sharp.UI.{symbol.Name}; {sealedStr}");
        }

        builder.AppendLine();

        foreach (var interfaceName in interfaceNameList)
            builder.AppendLine($@"global using {interfaceName} = Sharp.UI.{interfaceName};");

        context.AddSource($"GlobalUsings.g.cs", builder.ToString());
    }

    void GenerateInterfaces(IEnumerable<ISymbol> symbols)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("namespace Sharp.UI;");
        builder.AppendLine();
        builder.AppendLine();

        foreach (var symbol in symbols)
        {
            var mauiType = GetMauiType((INamedTypeSymbol)symbol);
            var type = mauiType;
            while (!type.Name.Equals("Object"))
            {
                var interfaceName = GetInterfaceName(type);
                if (!interfaceNameList.Contains(interfaceName))
                {
                    AddInterface(builder, type);
                    interfaceNameList.Add(interfaceName);
                }
                type = type.BaseType;
            }
        }
        context.AddSource($"Interfaces.g.cs", builder.ToString());
    }

    void AddInterface(StringBuilder builder, INamedTypeSymbol type)
    {
        var parentInterfaceName = GetInterfaceName(type.BaseType);
        var parentString = parentInterfaceName.Equals("IObject") ? "" : $" : {parentInterfaceName}"; 
        builder.AppendLine($@"public partial interface {GetInterfaceName(type)}{parentString} {{ }}");
    }

    void GenerateExtensions(IEnumerable<ISymbol> symbols)
    {
        List<INamedTypeSymbol> doneExtensions = new List<INamedTypeSymbol>();
        foreach (var symbol in symbols)
        {
            var mauiType = GetMauiType((INamedTypeSymbol)symbol);

            var type = mauiType;
            while (!type.Name.Equals("Object"))
            {
                if (!doneExtensions.Contains(type))
                {
                    this.GenerateExtension(type);
                    doneExtensions.Add(type);
                }
                type = type.BaseType;
            }
        }
    }

    void GenerateExtension(INamedTypeSymbol symbol)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();
        //builder.AppendLine("/*");

        new MauiExtensionBuilder(symbol, builder).Buid();

        builder.AppendLine();
        //builder.AppendLine("*/");
        builder.AppendLine();
        builder.AppendLine("#pragma warning restore CS8669");


        var tail = symbol.IsGenericType ? $".{symbol.TypeArguments.FirstOrDefault().Name}" : "";
        context.AddSource($"{symbol.ContainingNamespace}.{symbol.Name}{tail}.g.cs", builder.ToString());
    }

    void Generate(INamedTypeSymbol symbol, AttributeData wrapperAttribute)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS0108");
        builder.AppendLine("#pragma warning disable CS8625");
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();
        //builder.AppendLine("/*");

        new MauiSymbolBuilder(symbol, wrapperAttribute, builder).Buid();

        builder.AppendLine();
        //builder.AppendLine("*/");
        builder.AppendLine();
        builder.AppendLine("#pragma warning restore CS0108");
        builder.AppendLine("#pragma warning restore CS8625");
        builder.AppendLine("#pragma warning restore CS8669");

        var tail = symbol.IsGenericType ? $".{symbol.TypeArguments.FirstOrDefault().Name}" : "";

        context.AddSource($"{symbol.ContainingNamespace}.{symbol.Name}{tail}.g.cs", builder.ToString());
    }
}