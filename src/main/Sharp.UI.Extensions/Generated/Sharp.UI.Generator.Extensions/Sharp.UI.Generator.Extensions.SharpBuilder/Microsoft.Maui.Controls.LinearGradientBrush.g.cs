﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class LinearGradientBrushExtension
    {
        public static T StartPoint<T>(this T self,
            Microsoft.Maui.Graphics.Point startPoint)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty, startPoint);
            return self;
        }
        
        public static T StartPoint<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty, builder.GetValue());
            return self;
        }
        
        public static T StartPoint<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Point>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T StartPoint<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
        //    where T : Microsoft.Maui.Controls.LinearGradientBrush
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T EndPoint<T>(this T self,
            Microsoft.Maui.Graphics.Point endPoint)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty, endPoint);
            return self;
        }
        
        public static T EndPoint<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty, builder.GetValue());
            return self;
        }
        
        public static T EndPoint<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.LinearGradientBrush
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Point>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T EndPoint<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
        //    where T : Microsoft.Maui.Controls.LinearGradientBrush
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty));
        //    builder.Build();
        //    return self;
        //}
        
    }
}

#pragma warning restore CS8601
#nullable restore
