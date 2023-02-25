﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class UrlWebViewSourceExtension
    {
        public static T Url<T>(this T obj,
            string url)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, url);
            return obj;
        }
        
        public static T Url<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, builder.GetValue());
            return obj;
        }
        
        public static T Url<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Url<T>(this T obj,
            object url)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, url);
            return obj;
        }
        
        public static T Url<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty, builder.GetValue());
            return obj;
        }
        
        public static T Url<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.UrlWebViewSource
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.UrlWebViewSource.UrlProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
