﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class FontImageSourceExtension
    {
        public static T Color<T>(this T self,
            Microsoft.Maui.Graphics.Color color)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.ColorProperty, color);
            return self;
        }
        
        public static T Color<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.ColorProperty, builder.GetValue());
            return self;
        }
        
        public static T Color<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.FontImageSource
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.FontImageSource.ColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Color<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.FontImageSource
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.FontImageSource.ColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.FontFamilyProperty, builder.GetValue());
            return self;
        }
        
        public static T FontFamily<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.FontImageSource
            where TBuilder : PropertyBuilder<string>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.FontImageSource.FontFamilyProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontFamily<T>(this T self,
        //    System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        //    where T : Microsoft.Maui.Controls.FontImageSource
        //{
        //    var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.FontImageSource.FontFamilyProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T Glyph<T>(this T self,
            string glyph)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.GlyphProperty, glyph);
            return self;
        }
        
        public static T Glyph<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.GlyphProperty, builder.GetValue());
            return self;
        }
        
        public static T Glyph<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.FontImageSource
            where TBuilder : PropertyBuilder<string>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.FontImageSource.GlyphProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Glyph<T>(this T self,
        //    System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        //    where T : Microsoft.Maui.Controls.FontImageSource
        //{
        //    var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.FontImageSource.GlyphProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T Size<T>(this T self,
            double size)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.SizeProperty, size);
            return self;
        }
        
        public static T Size<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.SizeProperty, builder.GetValue());
            return self;
        }
        
        public static T Size<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.FontImageSource
            where TBuilder : PropertyBuilder<double>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.FontImageSource.SizeProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Size<T>(this T self,
        //    System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        //    where T : Microsoft.Maui.Controls.FontImageSource
        //{
        //    var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.FontImageSource.SizeProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.FontImageSource
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FontImageSource.FontAutoScalingEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAutoScalingEnabled<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.FontImageSource
            where TBuilder : PropertyBuilder<bool>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.FontImageSource.FontAutoScalingEnabledProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontAutoScalingEnabled<T>(this T self,
        //    System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
        //    where T : Microsoft.Maui.Controls.FontImageSource
        //{
        //    var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.FontImageSource.FontAutoScalingEnabledProperty));
        //    builder.Build();
        //    return self;
        //}
        
    }
}

#pragma warning restore CS8601
#nullable restore
