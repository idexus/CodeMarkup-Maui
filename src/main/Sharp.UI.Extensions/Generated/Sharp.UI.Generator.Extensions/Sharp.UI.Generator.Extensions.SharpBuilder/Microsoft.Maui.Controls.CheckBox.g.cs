﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class CheckBoxExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.ColorProperty, color);
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.ColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.CheckBox.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            Microsoft.Maui.Graphics.Color fromValue = self.Color;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.Color = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateColorTo", transform, callback, length, easing);
        }
        
        public static T IsChecked<T>(this T obj,
            bool isChecked)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, isChecked);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.CheckBox.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CheckedChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.CheckedChanged += handler;
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.CheckedChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            object isChecked)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, isChecked);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CheckBox.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            object color)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.ColorProperty, color);
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CheckBox.ColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.CheckBox
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CheckBox.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
