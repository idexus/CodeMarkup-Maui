﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class CompatibilityLayoutExtension
    {
        public static T IsClippedToBounds<T>(this T self,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return self;
        }
        
        public static T IsClippedToBounds<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, Value = isClippedToBounds });
            return self;
        }
        
        public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, Value = padding });
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, Value = cascadeInputTransparent });
            return self;
        }
        
        public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.LayoutChanged += handler;
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.LayoutChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
