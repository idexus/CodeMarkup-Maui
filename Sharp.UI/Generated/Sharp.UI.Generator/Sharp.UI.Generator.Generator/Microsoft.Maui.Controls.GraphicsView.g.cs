﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class GraphicsViewGeneratedExtension
    {
        public static T Drawable<T>(this T obj,
            Microsoft.Maui.Graphics.IDrawable? drawable)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            if (drawable != null) mauiObject.Drawable = (Microsoft.Maui.Graphics.IDrawable)drawable;
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            Microsoft.Maui.Graphics.IDrawable? drawable,
            System.Func<BindableDef<Microsoft.Maui.Graphics.IDrawable>, BindableDef<Microsoft.Maui.Graphics.IDrawable>> definition)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);         
            if (drawable != null) mauiObject.Drawable = (Microsoft.Maui.Graphics.IDrawable)drawable;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.IDrawable>(mauiObject, Microsoft.Maui.Controls.GraphicsView.DrawableProperty));
            if (def.ValueIsSet()) mauiObject.Drawable = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.IDrawable>, BindableDef<Microsoft.Maui.Graphics.IDrawable>> definition)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.IDrawable>(mauiObject, Microsoft.Maui.Controls.GraphicsView.DrawableProperty));
            if (def.ValueIsSet()) mauiObject.Drawable = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnStartHoverInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.StartHoverInteraction += handler;
            return obj;
        }
        
        public static T OnStartHoverInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.StartHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnMoveHoverInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.MoveHoverInteraction += handler;
            return obj;
        }
        
        public static T OnMoveHoverInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.MoveHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnEndHoverInteraction<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.EndHoverInteraction += handler;
            return obj;
        }
        
        public static T OnEndHoverInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.EndHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnStartInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.StartInteraction += handler;
            return obj;
        }
        
        public static T OnStartInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.StartInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.DragInteraction += handler;
            return obj;
        }
        
        public static T OnDragInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.DragInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnEndInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.EndInteraction += handler;
            return obj;
        }
        
        public static T OnEndInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.EndInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnCancelInteraction<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.CancelInteraction += handler;
            return obj;
        }
        
        public static T OnCancelInteraction<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGraphicsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GraphicsView>(obj);
            mauiObject.CancelInteraction += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
