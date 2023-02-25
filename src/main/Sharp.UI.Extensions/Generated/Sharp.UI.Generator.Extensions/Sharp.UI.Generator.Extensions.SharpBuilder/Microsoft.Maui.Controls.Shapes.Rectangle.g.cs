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
        
        public static Task<bool> AnimateRadiusXTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusX;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusX = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusXTo", transform, callback, length, easing);
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
        
        public static Task<bool> AnimateRadiusYTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusY;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusY = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusYTo", transform, callback, length, easing);
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            object radiusX)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, radiusX);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            object radiusY)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, radiusY);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
