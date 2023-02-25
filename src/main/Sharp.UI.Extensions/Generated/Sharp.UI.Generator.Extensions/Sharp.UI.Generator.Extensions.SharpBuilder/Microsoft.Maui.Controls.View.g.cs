﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ViewExtension
    {
        public static T GestureRecognizers<T>(this T obj,
            IList<Microsoft.Maui.Controls.IGestureRecognizer> gestureRecognizers)
            where T : Microsoft.Maui.Controls.View
        {
            foreach (var item in gestureRecognizers)
                obj.GestureRecognizers.Add(item);
            return obj;
        }

        public static T GestureRecognizers<T>(this T obj,
            params Microsoft.Maui.Controls.IGestureRecognizer[] gestureRecognizers)
            where T : Microsoft.Maui.Controls.View
        {
            foreach (var item in gestureRecognizers)
                obj.GestureRecognizers.Add(item);
            return obj;
        }
        
        public static T HorizontalOptions<T>(this T obj,
            Microsoft.Maui.Controls.LayoutOptions horizontalOptions)
            where T : Microsoft.Maui.Controls.View
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, horizontalOptions);
            return obj;
        }
        
        public static T HorizontalOptions<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>, ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>> buidValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, builder.GetValue());
            return obj;
        }
        
        public static T HorizontalOptions<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>, BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>> buidBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>(obj, Microsoft.Maui.Controls.View.HorizontalOptionsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Margin<T>(this T obj,
            Microsoft.Maui.Thickness margin)
            where T : Microsoft.Maui.Controls.View
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.View.MarginProperty, margin);
            return obj;
        }
        
        public static T Margin<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.View.MarginProperty, builder.GetValue());
            return obj;
        }
        
        public static T Margin<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.View.MarginProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalOptions<T>(this T obj,
            Microsoft.Maui.Controls.LayoutOptions verticalOptions)
            where T : Microsoft.Maui.Controls.View
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.View.VerticalOptionsProperty, verticalOptions);
            return obj;
        }
        
        public static T VerticalOptions<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>, ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>> buidValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.View.VerticalOptionsProperty, builder.GetValue());
            return obj;
        }
        
        public static T VerticalOptions<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>, BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>> buidBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>(obj, Microsoft.Maui.Controls.View.VerticalOptionsProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
