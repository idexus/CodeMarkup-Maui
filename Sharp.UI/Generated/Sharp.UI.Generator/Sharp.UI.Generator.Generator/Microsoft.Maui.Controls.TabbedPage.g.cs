﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TabbedPageGeneratedExtension
    {
        public static T BarBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barBackgroundColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarBackgroundColor = (Microsoft.Maui.Graphics.Color)barBackgroundColor;
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barBackgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);         
            mauiObject.BarBackgroundColor = (Microsoft.Maui.Graphics.Color)barBackgroundColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BarBackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BarBackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush barBackground)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarBackground = (Microsoft.Maui.Controls.Brush)barBackground;
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush barBackground,
            System.Func<BindableDef<Microsoft.Maui.Controls.Brush>, BindableDef<Microsoft.Maui.Controls.Brush>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);         
            mauiObject.BarBackground = (Microsoft.Maui.Controls.Brush)barBackground;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Brush>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty));
            if (def.ValueIsSet()) mauiObject.BarBackground = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Brush>, BindableDef<Microsoft.Maui.Controls.Brush>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Brush>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty));
            if (def.ValueIsSet()) mauiObject.BarBackground = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barTextColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.BarTextColor = (Microsoft.Maui.Graphics.Color)barTextColor;
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color barTextColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);         
            mauiObject.BarTextColor = (Microsoft.Maui.Graphics.Color)barTextColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty));
            if (def.ValueIsSet()) mauiObject.BarTextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty));
            if (def.ValueIsSet()) mauiObject.BarTextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color unselectedTabColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.UnselectedTabColor = (Microsoft.Maui.Graphics.Color)unselectedTabColor;
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color unselectedTabColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);         
            mauiObject.UnselectedTabColor = (Microsoft.Maui.Graphics.Color)unselectedTabColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty));
            if (def.ValueIsSet()) mauiObject.UnselectedTabColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T UnselectedTabColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty));
            if (def.ValueIsSet()) mauiObject.UnselectedTabColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color selectedTabColor)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            mauiObject.SelectedTabColor = (Microsoft.Maui.Graphics.Color)selectedTabColor;
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color selectedTabColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);         
            mauiObject.SelectedTabColor = (Microsoft.Maui.Graphics.Color)selectedTabColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty));
            if (def.ValueIsSet()) mauiObject.SelectedTabColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedTabColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITabbedPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TabbedPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty));
            if (def.ValueIsSet()) mauiObject.SelectedTabColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
