﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RadialGradientBrushGeneratedExtension
    {
        public static T Center<T>(this T obj,
            Microsoft.Maui.Graphics.Point? center)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            if (center != null) mauiObject.Center = (Microsoft.Maui.Graphics.Point)center;
            return obj;
        }
        
        public static T Center<T>(this T obj,
            Microsoft.Maui.Graphics.Point? center,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);         
            if (center != null) mauiObject.Center = (Microsoft.Maui.Graphics.Point)center;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty));
            if (def.ValueIsSet()) mauiObject.Center = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Center<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.CenterProperty));
            if (def.ValueIsSet()) mauiObject.Center = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            double? radius)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            if (radius != null) mauiObject.Radius = (double)radius;
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            double? radius,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);         
            if (radius != null) mauiObject.Radius = (double)radius;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty));
            if (def.ValueIsSet()) mauiObject.Radius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Radius<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRadialGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadialGradientBrush>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.RadialGradientBrush.RadiusProperty));
            if (def.ValueIsSet()) mauiObject.Radius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
