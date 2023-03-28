﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class PickerExtension
    {
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Picker.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.FontAttributesProperty, Value = fontAttributes });
            return self;
        }
        
        public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>, IPropertySettersBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>(self.XamlSetters, Microsoft.Maui.Controls.Picker.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Picker.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.FontFamilyProperty, Value = fontFamily });
            return self;
        }
        
        public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Picker.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Picker.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.FontSizeProperty, Value = fontSize });
            return self;
        }
        
        public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Picker.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
            return self;
        }
        
        public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Items<T>(this T self,
            IList<string> items)
            where T : Microsoft.Maui.Controls.Picker
        {
            foreach (var item in items)
                self.Items.Add(item);
            return self;
        }

        public static T Items<T>(this T self,
            params string[] items)
            where T : Microsoft.Maui.Controls.Picker
        {
            foreach (var item in items)
                self.Items.Add(item);
            return self;
        }
        
        public static T ItemsSource<T>(this T self,
            System.Collections.IList itemsSource)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IList>, IPropertyBuilder<System.Collections.IList>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<System.Collections.IList>(self, Microsoft.Maui.Controls.Picker.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
            System.Collections.IList itemsSource)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.ItemsSourceProperty, Value = itemsSource });
            return self;
        }
        
        public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IList>, IPropertySettersBuilder<System.Collections.IList>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<System.Collections.IList>(self.XamlSetters, Microsoft.Maui.Controls.Picker.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectedIndex<T>(this T self,
            int selectedIndex)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.SelectedIndexProperty, selectedIndex);
            return self;
        }
        
        public static T SelectedIndex<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Picker.SelectedIndexProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectedIndex<T>(this SettersContext<T> self,
            int selectedIndex)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.SelectedIndexProperty, Value = selectedIndex });
            return self;
        }
        
        public static SettersContext<T> SelectedIndex<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Picker.SelectedIndexProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectedItem<T>(this T self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.SelectedItemProperty, selectedItem);
            return self;
        }
        
        public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.Picker.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.SelectedItemProperty, Value = selectedItem });
            return self;
        }
        
        public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.Picker.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Picker.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.TextColorProperty, Value = textColor });
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Picker.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, Value = characterSpacing });
            return self;
        }
        
        public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T Title<T>(this T self,
            string title)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Picker.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self,
            string title)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.TitleProperty, Value = title });
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Picker.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TitleColor<T>(this T self,
            Microsoft.Maui.Graphics.Color titleColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.TitleColorProperty, titleColor);
            return self;
        }
        
        public static T TitleColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Picker.TitleColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TitleColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color titleColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.TitleColorProperty, Value = titleColor });
            return self;
        }
        
        public static SettersContext<T> TitleColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Picker.TitleColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTitleColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TitleColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TitleColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTitleColorTo", transform, callback, length, easing);
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemDisplayBinding<T>(this T self,
            Microsoft.Maui.Controls.BindingBase itemDisplayBinding)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.ItemDisplayBinding = itemDisplayBinding;
            return self;
        }
        
        public static T OnSelectedIndexChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SelectedIndexChanged += handler;
            return self;
        }
        
        public static T OnSelectedIndexChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SelectedIndexChanged += (o, arg) => action(self);
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker, Microsoft.Maui.ITextAlignment
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValue(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore
