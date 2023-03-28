﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ColumnDefinitionExtension
    {
        public static Microsoft.Maui.Controls.ColumnDefinition Width(this Microsoft.Maui.Controls.ColumnDefinition self,
            Microsoft.Maui.GridLength width)
        {
            self.SetValue(Microsoft.Maui.Controls.ColumnDefinition.WidthProperty, width);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition Width(this Microsoft.Maui.Controls.ColumnDefinition self, Func<PropertyContext<Microsoft.Maui.GridLength>, IPropertyBuilder<Microsoft.Maui.GridLength>> configure)
        {
            var context = new PropertyContext<Microsoft.Maui.GridLength>(self, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ColumnDefinition> Width(this SettersContext<Microsoft.Maui.Controls.ColumnDefinition> self,
            Microsoft.Maui.GridLength width)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ColumnDefinition.WidthProperty, Value = width });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ColumnDefinition> Width(this SettersContext<Microsoft.Maui.Controls.ColumnDefinition> self, Func<PropertySettersContext<Microsoft.Maui.GridLength>, IPropertySettersBuilder<Microsoft.Maui.GridLength>> configure)
        {
            var context = new PropertySettersContext<Microsoft.Maui.GridLength>(self.XamlSetters, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition OnSizeChanged(this Microsoft.Maui.Controls.ColumnDefinition self, System.EventHandler handler)
        {
            self.SizeChanged += handler;
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition OnSizeChanged(this Microsoft.Maui.Controls.ColumnDefinition self, System.Action<Microsoft.Maui.Controls.ColumnDefinition> action)
        {
            self.SizeChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
