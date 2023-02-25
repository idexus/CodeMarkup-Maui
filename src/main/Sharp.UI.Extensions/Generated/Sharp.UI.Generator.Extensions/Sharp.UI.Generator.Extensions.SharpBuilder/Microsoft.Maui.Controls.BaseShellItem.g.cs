﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class BaseShellItemExtension
    {
        public static T FlyoutIcon<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource flyoutIcon)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, flyoutIcon);
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, builder.GetValue());
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource icon)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IconProperty, icon);
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IconProperty, builder.GetValue());
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.BaseShellItem.IconProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, isEnabled);
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Route<T>(this T obj,
            string route)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Route");
            obj.Route = route;
            return obj;
        }
        
        public static T Route<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Route");
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Route = builder.GetValue();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string title)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, title);
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, builder.GetValue());
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.BaseShellItem.TitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool isVisible)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, isVisible);
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FlyoutItemIsVisible<T>(this T obj,
            bool flyoutItemIsVisible)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property FlyoutItemIsVisible");
            obj.FlyoutItemIsVisible = flyoutItemIsVisible;
            return obj;
        }
        
        public static T FlyoutItemIsVisible<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property FlyoutItemIsVisible");
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.FlyoutItemIsVisible = builder.GetValue();
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.Appearing += handler;
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.Appearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.Disappearing += handler;
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.Disappearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            object flyoutIcon)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, flyoutIcon);
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, builder.GetValue());
            return obj;
        }
        
        public static T FlyoutIcon<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            object icon)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IconProperty, icon);
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IconProperty, builder.GetValue());
            return obj;
        }
        
        public static T Icon<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.IconProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            object isChecked)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty, isChecked);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            object isEnabled)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, isEnabled);
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            object title)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, title);
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, builder.GetValue());
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.TitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            object isVisible)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, isVisible);
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Window<T>(this T obj,
            object window)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.WindowProperty, window);
            return obj;
        }
        
        public static T Window<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.BaseShellItem.WindowProperty, builder.GetValue());
            return obj;
        }
        
        public static T Window<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.BaseShellItem
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.BaseShellItem.WindowProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
