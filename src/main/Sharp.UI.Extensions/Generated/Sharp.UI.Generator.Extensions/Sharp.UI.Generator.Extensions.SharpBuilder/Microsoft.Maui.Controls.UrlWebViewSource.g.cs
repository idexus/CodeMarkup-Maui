﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class UrlWebViewSourceExtension
    {
        public static T Url<T>(this T self,
            string url)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, url);
            return self;
        }
        
        public static T Url<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, builder.GetValue());
            return self;
        }
        
        public static T Url<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
            where TBuilder : PropertyBuilder<string>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Url<T>(this T self,
        //    System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        //    where T : Microsoft.Maui.Controls.UrlWebViewSource
        //{
        //    var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty));
        //    builder.Build();
        //    return self;
        //}
        
    }
}

#pragma warning restore CS8601
#nullable restore
