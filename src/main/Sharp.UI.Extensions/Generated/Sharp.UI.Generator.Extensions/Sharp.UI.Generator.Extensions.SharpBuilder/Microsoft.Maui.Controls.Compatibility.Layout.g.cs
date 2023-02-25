﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class CompatibilityLayoutExtension
    {
        public static T IsClippedToBounds<T>(this T obj,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, builder.GetValue());
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnLayoutChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.LayoutChanged += handler;
            return obj;
        }
        
        public static T OnLayoutChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.LayoutChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            object isClippedToBounds)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            object cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, builder.GetValue());
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            object padding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
