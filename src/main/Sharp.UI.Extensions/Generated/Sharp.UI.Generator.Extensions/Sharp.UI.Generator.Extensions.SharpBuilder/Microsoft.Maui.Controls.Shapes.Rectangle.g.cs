﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    using Sharp.UI.Internal;

    public static partial class RectangleExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            double radiusX)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, radiusX);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            double radiusY)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, radiusY);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
