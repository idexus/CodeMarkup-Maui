﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ITabGeneratedExtension
    {
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? itemTemplate)
            where T : Sharp.UI.ITab
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Tab>(obj);
            if (itemTemplate != null) mauiObject.SetValue(Shell.ItemTemplateProperty, (Microsoft.Maui.Controls.DataTemplate)itemTemplate);
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? itemTemplate,
            Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.ITab
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Tab>(obj);
            if (itemTemplate != null) mauiObject.SetValue(Shell.ItemTemplateProperty, (Microsoft.Maui.Controls.DataTemplate)itemTemplate);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Shell.ItemTemplateProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Shell.ItemTemplateProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.ITab
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Tab>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Shell.ItemTemplateProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Shell.ItemTemplateProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj, Func<object> loadTemplate) where T : Sharp.UI.ITab
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Tab>(obj);
            mauiObject.SetValue(Shell.ItemTemplateProperty, new Microsoft.Maui.Controls.DataTemplate(loadTemplate));
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
