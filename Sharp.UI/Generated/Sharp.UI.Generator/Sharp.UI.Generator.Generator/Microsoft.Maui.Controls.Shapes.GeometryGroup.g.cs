﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class GeometryGroupGeneratedExtension
    {
        public static T Children<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.GeometryCollection? children)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            if (children != null) mauiObject.Children = (Microsoft.Maui.Controls.Shapes.GeometryCollection)children;
            return obj;
        }
        
        public static T Children<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.GeometryCollection? children,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>, BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>> definition)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);         
            if (children != null) mauiObject.Children = (Microsoft.Maui.Controls.Shapes.GeometryCollection)children;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.GeometryGroup.ChildrenProperty));
            if (def.ValueIsSet()) mauiObject.Children = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Children<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>, BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>> definition)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.GeometryCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.GeometryGroup.ChildrenProperty));
            if (def.ValueIsSet()) mauiObject.Children = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.FillRule? fillRule)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            if (fillRule != null) mauiObject.FillRule = (Microsoft.Maui.Controls.Shapes.FillRule)fillRule;
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.FillRule? fillRule,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>, BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>> definition)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);         
            if (fillRule != null) mauiObject.FillRule = (Microsoft.Maui.Controls.Shapes.FillRule)fillRule;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>(mauiObject, Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty));
            if (def.ValueIsSet()) mauiObject.FillRule = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FillRule<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>, BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>> definition)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Shapes.FillRule>(mauiObject, Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty));
            if (def.ValueIsSet()) mauiObject.FillRule = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnInvalidateGeometryRequested<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            mauiObject.InvalidateGeometryRequested += handler;
            return obj;
        }
        
        public static T OnInvalidateGeometryRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGeometryGroup
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.GeometryGroup>(obj);
            mauiObject.InvalidateGeometryRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
