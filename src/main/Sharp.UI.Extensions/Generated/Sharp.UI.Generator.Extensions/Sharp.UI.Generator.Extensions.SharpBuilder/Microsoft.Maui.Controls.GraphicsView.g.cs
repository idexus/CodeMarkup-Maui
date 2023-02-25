﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class GraphicsViewExtension
    {
        public static T Drawable<T>(this T obj,
            Microsoft.Maui.Graphics.IDrawable drawable)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.GraphicsView.DrawableProperty, drawable);
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.IDrawable>, ValueBuilder<Microsoft.Maui.Graphics.IDrawable>> buidValue)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.IDrawable>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.GraphicsView.DrawableProperty, builder.GetValue());
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.IDrawable>, BindingBuilder<Microsoft.Maui.Graphics.IDrawable>> buidBinding)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.IDrawable>(obj, Microsoft.Maui.Controls.GraphicsView.DrawableProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnStartHoverInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.StartHoverInteraction += handler;
            return obj;
        }
        
        public static T OnStartHoverInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.StartHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnMoveHoverInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.MoveHoverInteraction += handler;
            return obj;
        }
        
        public static T OnMoveHoverInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.MoveHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnEndHoverInteraction<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.EndHoverInteraction += handler;
            return obj;
        }
        
        public static T OnEndHoverInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.EndHoverInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnStartInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.StartInteraction += handler;
            return obj;
        }
        
        public static T OnStartInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.StartInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.DragInteraction += handler;
            return obj;
        }
        
        public static T OnDragInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.DragInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnEndInteraction<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.EndInteraction += handler;
            return obj;
        }
        
        public static T OnEndInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.EndInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnCancelInteraction<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.CancelInteraction += handler;
            return obj;
        }
        
        public static T OnCancelInteraction<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.CancelInteraction += (o, arg) => action(obj);
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            object drawable)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.GraphicsView.DrawableProperty, drawable);
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.GraphicsView.DrawableProperty, builder.GetValue());
            return obj;
        }
        
        public static T Drawable<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.GraphicsView.DrawableProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
