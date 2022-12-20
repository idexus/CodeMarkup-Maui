﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BoxViewGeneratedExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);
            mauiObject.Color = (Microsoft.Maui.Graphics.Color)color;
            return obj;
        }
        
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);         
            mauiObject.Color = (Microsoft.Maui.Graphics.Color)color;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.BoxView.ColorProperty));
            if (def.ValueIsSet()) mauiObject.Color = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.BoxView.ColorProperty));
            if (def.ValueIsSet()) mauiObject.Color = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius cornerRadius)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);
            mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            Microsoft.Maui.CornerRadius cornerRadius,
            System.Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);         
            mauiObject.CornerRadius = (Microsoft.Maui.CornerRadius)cornerRadius;
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.CornerRadius>, BindableDef<Microsoft.Maui.CornerRadius>> definition)
            where T : Sharp.UI.IBoxView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BoxView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.CornerRadius>(mauiObject, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
