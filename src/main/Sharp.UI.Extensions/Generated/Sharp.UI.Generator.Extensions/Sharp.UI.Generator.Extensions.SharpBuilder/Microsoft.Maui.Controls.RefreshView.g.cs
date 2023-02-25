﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class RefreshViewExtension
    {
        public static T IsRefreshing<T>(this T obj,
            bool isRefreshing)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, isRefreshing);
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandProperty, command);
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.RefreshView.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, commandParameter);
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, builder.GetValue());
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RefreshView.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color refreshColor)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, refreshColor);
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateRefreshColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.RefreshColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.RefreshColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateRefreshColorTo", transform, callback, length, easing);
        }
        
        public static T OnRefreshing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.Refreshing += handler;
            return obj;
        }
        
        public static T OnRefreshing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.Refreshing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            object isRefreshing)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, isRefreshing);
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            object command)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandProperty, command);
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RefreshView.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, commandParameter);
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, builder.GetValue());
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RefreshView.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            object refreshColor)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, refreshColor);
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
