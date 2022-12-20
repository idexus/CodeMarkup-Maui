﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class QuadraticBezierSegmentGeneratedExtension
    {
        public static T Point1<T>(this T obj,
            Microsoft.Maui.Graphics.Point point1)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);
            mauiObject.Point1 = (Microsoft.Maui.Graphics.Point)point1;
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            Microsoft.Maui.Graphics.Point point1,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);         
            mauiObject.Point1 = (Microsoft.Maui.Graphics.Point)point1;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property));
            if (def.ValueIsSet()) mauiObject.Point1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point1<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property));
            if (def.ValueIsSet()) mauiObject.Point1 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            Microsoft.Maui.Graphics.Point point2)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);
            mauiObject.Point2 = (Microsoft.Maui.Graphics.Point)point2;
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            Microsoft.Maui.Graphics.Point point2,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);         
            mauiObject.Point2 = (Microsoft.Maui.Graphics.Point)point2;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property));
            if (def.ValueIsSet()) mauiObject.Point2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Point2<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.IQuadraticBezierSegment
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property));
            if (def.ValueIsSet()) mauiObject.Point2 = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
