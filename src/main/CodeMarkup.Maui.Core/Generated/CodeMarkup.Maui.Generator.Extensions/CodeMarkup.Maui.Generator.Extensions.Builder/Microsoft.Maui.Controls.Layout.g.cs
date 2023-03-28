﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class LayoutExtension
    {
        public static T Children<T>(this T self,
            IList<Microsoft.Maui.IView> children)
            where T : Microsoft.Maui.Controls.Layout
        {
            foreach (var item in children)
                self.Children.Add(item);
            return self;
        }

        public static T Children<T>(this T self,
            params Microsoft.Maui.IView[] children)
            where T : Microsoft.Maui.Controls.Layout
        {
            foreach (var item in children)
                self.Children.Add(item);
            return self;
        }
        
        public static T IsClippedToBounds<T>(this T self,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return self;
        }
        
        public static T IsClippedToBounds<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, Value = isClippedToBounds });
            return self;
        }
        
        public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Layout.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Layout.PaddingProperty, Value = padding });
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Layout.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IgnoreSafeArea<T>(this T self,
            bool ignoreSafeArea)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.IgnoreSafeArea = ignoreSafeArea;
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.SetValue(Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Layout
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, Value = cascadeInputTransparent });
            return self;
        }
        
        public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Layout
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
