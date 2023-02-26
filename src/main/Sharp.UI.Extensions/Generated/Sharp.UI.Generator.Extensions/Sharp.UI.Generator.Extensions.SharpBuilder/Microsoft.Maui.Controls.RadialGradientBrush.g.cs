﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class RadialGradientBrushExtension
    {
        public static T Center<T>(this T self,
            Microsoft.Maui.Graphics.Point center)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty, center);
            return self;
        }
        
        public static T Center<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty, builder.GetValue());
            return self;
        }
        
        public static T Center<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Point>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Center<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
        //    where T : Microsoft.Maui.Controls.RadialGradientBrush
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T Radius<T>(this T self,
            double radius)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty, radius);
            return self;
        }
        
        public static T Radius<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty, builder.GetValue());
            return self;
        }
        
        public static T Radius<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.RadialGradientBrush
            where TBuilder : PropertyBuilder<double>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Radius<T>(this T self,
        //    System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        //    where T : Microsoft.Maui.Controls.RadialGradientBrush
        //{
        //    var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty));
        //    builder.Build();
        //    return self;
        //}
        
    }
}

#pragma warning restore CS8601
#nullable restore
