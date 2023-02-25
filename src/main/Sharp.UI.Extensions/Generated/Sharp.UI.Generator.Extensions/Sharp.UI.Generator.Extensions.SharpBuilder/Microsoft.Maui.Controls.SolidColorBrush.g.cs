﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class SolidColorBrushExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.SolidColorBrush.ColorProperty, color);
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.SolidColorBrush.ColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.SolidColorBrush.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            object color)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.SolidColorBrush.ColorProperty, color);
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.SolidColorBrush.ColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.SolidColorBrush
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.SolidColorBrush.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
