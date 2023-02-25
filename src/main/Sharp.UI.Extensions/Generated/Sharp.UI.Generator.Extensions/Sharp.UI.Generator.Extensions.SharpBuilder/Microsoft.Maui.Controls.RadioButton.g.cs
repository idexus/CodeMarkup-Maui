﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class RadioButtonExtension
    {
        public static T Content<T>(this T obj,
            object content)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ContentProperty, content);
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ContentProperty, builder.GetValue());
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object value)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ValueProperty, value);
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            bool isChecked)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, isChecked);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            string groupName)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.GroupNameProperty, groupName);
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.GroupNameProperty, builder.GetValue());
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.RadioButton.GroupNameProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextColorProperty, textColor);
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.RadioButton.TextColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, characterSpacing);
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextTransformProperty, textTransform);
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextTransform>, ValueBuilder<Microsoft.Maui.TextTransform>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextTransformProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextTransform>, BindingBuilder<Microsoft.Maui.TextTransform>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.TextTransform>(obj, Microsoft.Maui.Controls.RadioButton.TextTransformProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, fontAttributes);
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(obj, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string fontFamily)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, fontFamily);
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double fontSize)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, fontSize);
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.RadioButton.FontSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double borderWidth)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, borderWidth);
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.BorderWidth;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.BorderWidth = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderColorProperty, borderColor);
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.RadioButton.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
        }
        
        public static T CornerRadius<T>(this T obj,
            int cornerRadius)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, cornerRadius);
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, builder.GetValue());
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CheckedChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.CheckedChanged += handler;
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.CheckedChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T Content<T>(this T obj,
            object content)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ContentProperty, content);
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ContentProperty, builder.GetValue());
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object value)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ValueProperty, value);
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            object isChecked)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, isChecked);
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            object groupName)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.GroupNameProperty, groupName);
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.GroupNameProperty, builder.GetValue());
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.GroupNameProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            object textColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextColorProperty, textColor);
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.TextColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            object characterSpacing)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, characterSpacing);
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            object textTransform)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextTransformProperty, textTransform);
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.TextTransformProperty, builder.GetValue());
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.TextTransformProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            object fontAttributes)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, fontAttributes);
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            object fontFamily)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, fontFamily);
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            object fontSize)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, fontSize);
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.FontSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            object fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            object borderColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderColorProperty, borderColor);
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            object cornerRadius)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, cornerRadius);
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, builder.GetValue());
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            object borderWidth)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, borderWidth);
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
