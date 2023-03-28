﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ElementExtension
    {
        public static T ContextFlyout<T>(this T self,
            Microsoft.Maui.Controls.MenuFlyout contextFlyout)
            where T : Microsoft.Maui.Controls.Element
        {
            self.SetValue(Microsoft.Maui.Controls.FlyoutBase.ContextFlyoutProperty, contextFlyout);
            return self;
        }
        
        public static T ContextFlyout<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.MenuFlyout>, IPropertyBuilder<Microsoft.Maui.Controls.MenuFlyout>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.MenuFlyout>(self, Microsoft.Maui.Controls.FlyoutBase.ContextFlyoutProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ContextFlyout<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.MenuFlyout contextFlyout)
            where T : Microsoft.Maui.Controls.Element
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.FlyoutBase.ContextFlyoutProperty, Value = contextFlyout });
            return self;
        }
        
        public static SettersContext<T> ContextFlyout<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.MenuFlyout>, IPropertySettersBuilder<Microsoft.Maui.Controls.MenuFlyout>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.MenuFlyout>(self.XamlSetters, Microsoft.Maui.Controls.FlyoutBase.ContextFlyoutProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.MenuFlyout GetContextFlyoutValue<T>(this T self)
            where T : Microsoft.Maui.Controls.Element
        {
            return (Microsoft.Maui.Controls.MenuFlyout)self.GetValue(Microsoft.Maui.Controls.FlyoutBase.ContextFlyoutProperty);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
