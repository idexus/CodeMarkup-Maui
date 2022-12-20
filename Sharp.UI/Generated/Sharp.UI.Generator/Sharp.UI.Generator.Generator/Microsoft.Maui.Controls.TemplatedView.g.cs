﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TemplatedViewGeneratedExtension
    {
        public static T ControlTemplate<T>(this T obj,
            Microsoft.Maui.Controls.ControlTemplate controlTemplate)
            where T : Sharp.UI.ITemplatedView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TemplatedView>(obj);
            mauiObject.ControlTemplate = (Microsoft.Maui.Controls.ControlTemplate)controlTemplate;
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            Microsoft.Maui.Controls.ControlTemplate controlTemplate,
            System.Func<BindableDef<Microsoft.Maui.Controls.ControlTemplate>, BindableDef<Microsoft.Maui.Controls.ControlTemplate>> definition)
            where T : Sharp.UI.ITemplatedView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TemplatedView>(obj);         
            mauiObject.ControlTemplate = (Microsoft.Maui.Controls.ControlTemplate)controlTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ControlTemplate>(mauiObject, Microsoft.Maui.Controls.TemplatedView.ControlTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ControlTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ControlTemplate<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ControlTemplate>, BindableDef<Microsoft.Maui.Controls.ControlTemplate>> definition)
            where T : Sharp.UI.ITemplatedView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TemplatedView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ControlTemplate>(mauiObject, Microsoft.Maui.Controls.TemplatedView.ControlTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ControlTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
