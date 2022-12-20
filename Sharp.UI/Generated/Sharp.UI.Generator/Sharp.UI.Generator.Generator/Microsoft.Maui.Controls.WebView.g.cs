﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class WebViewGeneratedExtension
    {
        public static T Cookies<T>(this T obj,
            System.Net.CookieContainer cookies)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Cookies = (System.Net.CookieContainer)cookies;
            return obj;
        }
        
        public static T Cookies<T>(this T obj,
            System.Net.CookieContainer cookies,
            System.Func<BindableDef<System.Net.CookieContainer>, BindableDef<System.Net.CookieContainer>> definition)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);         
            mauiObject.Cookies = (System.Net.CookieContainer)cookies;
            var def = definition(new BindableDef<System.Net.CookieContainer>(mauiObject, Microsoft.Maui.Controls.WebView.CookiesProperty));
            if (def.ValueIsSet()) mauiObject.Cookies = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Cookies<T>(this T obj,
            System.Func<BindableDef<System.Net.CookieContainer>, BindableDef<System.Net.CookieContainer>> definition)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            var def = definition(new BindableDef<System.Net.CookieContainer>(mauiObject, Microsoft.Maui.Controls.WebView.CookiesProperty));
            if (def.ValueIsSet()) mauiObject.Cookies = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            Microsoft.Maui.Controls.WebViewSource source)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Source = (Microsoft.Maui.Controls.WebViewSource)source;
            return obj;
        }
        
        public static T Source<T>(this T obj,
            Microsoft.Maui.Controls.WebViewSource source,
            System.Func<BindableDef<Microsoft.Maui.Controls.WebViewSource>, BindableDef<Microsoft.Maui.Controls.WebViewSource>> definition)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);         
            mauiObject.Source = (Microsoft.Maui.Controls.WebViewSource)source;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.WebViewSource>(mauiObject, Microsoft.Maui.Controls.WebView.SourceProperty));
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.WebViewSource>, BindableDef<Microsoft.Maui.Controls.WebViewSource>> definition)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.WebViewSource>(mauiObject, Microsoft.Maui.Controls.WebView.SourceProperty));
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnNavigated<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.WebNavigatedEventArgs> handler)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Navigated += handler;
            return obj;
        }
        
        public static T OnNavigated<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Navigated += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnNavigating<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.WebNavigatingEventArgs> handler)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Navigating += handler;
            return obj;
        }
        
        public static T OnNavigating<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IWebView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.WebView>(obj);
            mauiObject.Navigating += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
