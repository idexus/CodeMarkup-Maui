﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class StepperExtension
    {
        public static T Increment<T>(this T obj,
            double increment)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, increment);
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, builder.GetValue());
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Stepper.IncrementProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateIncrementTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Increment;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Increment = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateIncrementTo", transform, callback, length, easing);
        }
        
        public static T Maximum<T>(this T obj,
            double maximum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, maximum);
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Stepper.MaximumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMaximumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Maximum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Maximum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMaximumTo", transform, callback, length, easing);
        }
        
        public static T Minimum<T>(this T obj,
            double minimum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, minimum);
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Stepper.MinimumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMinimumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Minimum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Minimum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMinimumTo", transform, callback, length, easing);
        }
        
        public static T Value<T>(this T obj,
            double value)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, value);
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Stepper.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateValueTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Value;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Value = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateValueTo", transform, callback, length, easing);
        }
        
        public static T OnValueChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ValueChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.ValueChanged += handler;
            return obj;
        }
        
        public static T OnValueChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.ValueChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            object maximum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, maximum);
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Stepper.MaximumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            object minimum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, minimum);
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Stepper.MinimumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object value)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, value);
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Stepper.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            object increment)
            where T : Microsoft.Maui.Controls.Stepper
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, increment);
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, builder.GetValue());
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Stepper.IncrementProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
