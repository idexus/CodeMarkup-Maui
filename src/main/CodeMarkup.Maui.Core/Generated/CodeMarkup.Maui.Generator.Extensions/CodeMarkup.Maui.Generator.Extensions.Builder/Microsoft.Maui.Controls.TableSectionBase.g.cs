﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class TableSectionBaseExtension
    {
        public static T Title<T>(this T self,
            string title)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.SetValue(Microsoft.Maui.Controls.TableSectionBase.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.TableSectionBase.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self,
            string title)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TableSectionBase.TitleProperty, Value = title });
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.TableSectionBase.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.SetValue(Microsoft.Maui.Controls.TableSectionBase.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TableSectionBase.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TableSectionBase.TextColorProperty, Value = textColor });
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.TableSectionBase.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
