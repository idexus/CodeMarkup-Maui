﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    using Sharp.UI.Internal;

    public static partial class SpanExtension
    {
        public static T Style<T>(this T obj,
            Microsoft.Maui.Controls.Style style)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.StyleProperty, style);
            return obj;
        }
        
        public static T Style<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Style>, ValueBuilder<Microsoft.Maui.Controls.Style>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.StyleProperty, builder.GetValue());
            return obj;
        }
        
        public static T Style<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Style>, BindingBuilder<Microsoft.Maui.Controls.Style>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Style>(obj, Microsoft.Maui.Controls.Span.StyleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color backgroundColor)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.BackgroundColorProperty, backgroundColor);
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.BackgroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Span.BackgroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextColorProperty, textColor);
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Span.TextColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.CharacterSpacingProperty, characterSpacing);
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.CharacterSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Span.CharacterSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextTransformProperty, textTransform);
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextTransform>, ValueBuilder<Microsoft.Maui.TextTransform>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextTransformProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextTransform>, BindingBuilder<Microsoft.Maui.TextTransform>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.TextTransform>(obj, Microsoft.Maui.Controls.Span.TextTransformProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string text)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextProperty, text);
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextProperty, builder.GetValue());
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.Span.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontAttributesProperty, fontAttributes);
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontAttributesProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(obj, Microsoft.Maui.Controls.Span.FontAttributesProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontFamilyProperty, fontFamily);
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontFamilyProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.Span.FontFamilyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double fontSize)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontSizeProperty, fontSize);
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontSizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Span.FontSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            Microsoft.Maui.TextDecorations textDecorations)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextDecorationsProperty, textDecorations);
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextDecorations>, ValueBuilder<Microsoft.Maui.TextDecorations>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.TextDecorations>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.TextDecorationsProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextDecorations<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextDecorations>, BindingBuilder<Microsoft.Maui.TextDecorations>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.TextDecorations>(obj, Microsoft.Maui.Controls.Span.TextDecorationsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            double lineHeight)
            where T : Microsoft.Maui.Controls.Span
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.LineHeightProperty, lineHeight);
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Span.LineHeightProperty, builder.GetValue());
            return obj;
        }
        
        public static T LineHeight<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Span.LineHeightProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
