﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class LayoutExtension
    {
        public static T Children<T>(this T obj,
            IList<Microsoft.Maui.IView> children)
            where T : Microsoft.Maui.Controls.Layout
        {
            foreach (var item in children)
                obj.Children.Add(item);
            return obj;
        }

        public static T Children<T>(this T obj,
            params Microsoft.Maui.IView[] children)
            where T : Microsoft.Maui.Controls.Layout
        {
            foreach (var item in children)
                obj.Children.Add(item);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.Layout.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IgnoreSafeArea<T>(this T obj,
            bool ignoreSafeArea)
            where T : Microsoft.Maui.Controls.Layout
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IgnoreSafeArea");
            obj.IgnoreSafeArea = ignoreSafeArea;
            return obj;
        }
        
        public static T IgnoreSafeArea<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IgnoreSafeArea");
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IgnoreSafeArea = builder.GetValue();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, builder.GetValue());
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            object isClippedToBounds)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            object padding)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Layout.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            object cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Layout
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, builder.GetValue());
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Layout
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
