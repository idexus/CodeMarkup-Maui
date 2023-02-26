﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ButtonExtension
    {
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.PaddingProperty, builder.GetValue());
            return self;
        }
        
        public static T Padding<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Thickness>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.PaddingProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Padding<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Button.PaddingProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T LineBreakMode<T>(this T self,
            Microsoft.Maui.LineBreakMode lineBreakMode)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.LineBreakModeProperty, lineBreakMode);
            return self;
        }
        
        public static T LineBreakMode<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.LineBreakMode>, ValueBuilder<Microsoft.Maui.LineBreakMode>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.LineBreakMode>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.LineBreakModeProperty, builder.GetValue());
            return self;
        }
        
        public static T LineBreakMode<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.LineBreakMode>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.LineBreakModeProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T LineBreakMode<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.LineBreakMode>, BindingBuilder<Microsoft.Maui.LineBreakMode>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.LineBreakMode>(self, Microsoft.Maui.Controls.Button.LineBreakModeProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T BorderColor<T>(this T self,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.BorderColorProperty, borderColor);
            return self;
        }
        
        public static T BorderColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.BorderColorProperty, builder.GetValue());
            return self;
        }
        
        public static T BorderColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.BorderColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T BorderColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Button.BorderColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Button
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
        }
        
        public static T CornerRadius<T>(this T self,
            int cornerRadius)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CornerRadiusProperty, cornerRadius);
            return self;
        }
        
        public static T CornerRadius<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CornerRadiusProperty, builder.GetValue());
            return self;
        }
        
        public static T CornerRadius<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<int>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.CornerRadiusProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T CornerRadius<T>(this T self,
        //    System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Button.CornerRadiusProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T BorderWidth<T>(this T self,
            double borderWidth)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.BorderWidthProperty, borderWidth);
            return self;
        }
        
        public static T BorderWidth<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.BorderWidthProperty, builder.GetValue());
            return self;
        }
        
        public static T BorderWidth<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<double>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.BorderWidthProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T BorderWidth<T>(this T self,
        //    System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Button.BorderWidthProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Button
        {
            double fromValue = self.BorderWidth;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.BorderWidth = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
        }
        
        public static T ContentLayout<T>(this T self,
            Microsoft.Maui.Controls.Button.ButtonContentLayout contentLayout)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.ContentLayoutProperty, contentLayout);
            return self;
        }
        
        public static T ContentLayout<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>, ValueBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.ContentLayoutProperty, builder.GetValue());
            return self;
        }
        
        public static T ContentLayout<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.ContentLayoutProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T ContentLayout<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>, BindingBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>(self, Microsoft.Maui.Controls.Button.ContentLayoutProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CommandProperty, builder.GetValue());
            return self;
        }
        
        public static T Command<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<System.Windows.Input.ICommand>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.CommandProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Command<T>(this T self,
        //    System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.Button.CommandProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T CommandParameter<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<object>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.CommandParameterProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T CommandParameter<T>(this T self,
        //    System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.Button.CommandParameterProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T ImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource imageSource)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.ImageSourceProperty, imageSource);
            return self;
        }
        
        public static T ImageSource<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.ImageSourceProperty, builder.GetValue());
            return self;
        }
        
        public static T ImageSource<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Controls.ImageSource>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.ImageSourceProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T ImageSource<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.Button.ImageSourceProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextProperty, builder.GetValue());
            return self;
        }
        
        public static T Text<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<string>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.TextProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T Text<T>(this T self,
        //    System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.Button.TextProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextColorProperty, builder.GetValue());
            return self;
        }
        
        public static T TextColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.TextColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T TextColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Button.TextColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Button
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.CharacterSpacingProperty, builder.GetValue());
            return self;
        }
        
        public static T CharacterSpacing<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<double>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.CharacterSpacingProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T CharacterSpacing<T>(this T self,
        //    System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Button.CharacterSpacingProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Button
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontAttributesProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAttributes<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.Controls.FontAttributes>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.FontAttributesProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontAttributes<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Button.FontAttributesProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontFamilyProperty, builder.GetValue());
            return self;
        }
        
        public static T FontFamily<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<string>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.FontFamilyProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontFamily<T>(this T self,
        //    System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.Button.FontFamilyProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontSizeProperty, builder.GetValue());
            return self;
        }
        
        public static T FontSize<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<double>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.FontSizeProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontSize<T>(this T self,
        //    System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Button.FontSizeProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Button
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAutoScalingEnabled<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<bool>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T FontAutoScalingEnabled<T>(this T self,
        //    System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T TextTransform<T>(this T self,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.Button
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextTransformProperty, textTransform);
            return self;
        }
        
        public static T TextTransform<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.TextTransform>, ValueBuilder<Microsoft.Maui.TextTransform>> buildValue)
            where T : Microsoft.Maui.Controls.Button
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Button.TextTransformProperty, builder.GetValue());
            return self;
        }
        
        public static T TextTransform<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.Button
            where TBuilder : PropertyBuilder<Microsoft.Maui.TextTransform>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.Button.TextTransformProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T TextTransform<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.TextTransform>, BindingBuilder<Microsoft.Maui.TextTransform>> buildBinding)
        //    where T : Microsoft.Maui.Controls.Button
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextTransform>(self, Microsoft.Maui.Controls.Button.TextTransformProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T OnClicked<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Clicked += handler;
            return self;
        }
        
        public static T OnClicked<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Clicked += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPressed<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Pressed += handler;
            return self;
        }
        
        public static T OnPressed<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Pressed += (o, arg) => action(self);
            return self;
        }
        
        public static T OnReleased<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Released += handler;
            return self;
        }
        
        public static T OnReleased<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Button
        {
            self.Released += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
