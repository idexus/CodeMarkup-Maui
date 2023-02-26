﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class TabbedPageExtension
    {
        public static T BarBackgroundColor<T>(this T self,
            Microsoft.Maui.Graphics.Color barBackgroundColor)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty, barBackgroundColor);
            return self;
        }
        
        public static T BarBackgroundColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty, builder.GetValue());
            return self;
        }
        
        public static T BarBackgroundColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.TabbedPage
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T BarBackgroundColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.TabbedPage
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateBarBackgroundColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BarBackgroundColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BarBackgroundColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBarBackgroundColorTo", transform, callback, length, easing);
        }
        
        public static T BarBackground<T>(this T self,
            Microsoft.Maui.Controls.Brush barBackground)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty, barBackground);
            return self;
        }
        
        public static T BarBackground<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buildValue)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty, builder.GetValue());
            return self;
        }
        
        public static T BarBackground<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.TabbedPage
            where TBuilder : PropertyBuilder<Microsoft.Maui.Controls.Brush>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T BarBackground<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buildBinding)
        //    where T : Microsoft.Maui.Controls.TabbedPage
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(self, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static T BarTextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color barTextColor)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty, barTextColor);
            return self;
        }
        
        public static T BarTextColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty, builder.GetValue());
            return self;
        }
        
        public static T BarTextColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.TabbedPage
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T BarTextColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.TabbedPage
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateBarTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BarTextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BarTextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBarTextColorTo", transform, callback, length, easing);
        }
        
        public static T UnselectedTabColor<T>(this T self,
            Microsoft.Maui.Graphics.Color unselectedTabColor)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty, unselectedTabColor);
            return self;
        }
        
        public static T UnselectedTabColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty, builder.GetValue());
            return self;
        }
        
        public static T UnselectedTabColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.TabbedPage
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T UnselectedTabColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.TabbedPage
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateUnselectedTabColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            Microsoft.Maui.Graphics.Color fromValue = self.UnselectedTabColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.UnselectedTabColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateUnselectedTabColorTo", transform, callback, length, easing);
        }
        
        public static T SelectedTabColor<T>(this T self,
            Microsoft.Maui.Graphics.Color selectedTabColor)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty, selectedTabColor);
            return self;
        }
        
        public static T SelectedTabColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectedTabColor<T, TBuilder>(this T self,System.Action<TBuilder> configure)
            where T : Microsoft.Maui.Controls.TabbedPage
            where TBuilder : PropertyBuilder<Microsoft.Maui.Graphics.Color>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty);
            configure(builder);
            builder.Build();
            return self;

        }

        //public static T SelectedTabColor<T>(this T self,
        //    System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
        //    where T : Microsoft.Maui.Controls.TabbedPage
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Task<bool> AnimateSelectedTabColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.TabbedPage
        {
            Microsoft.Maui.Graphics.Color fromValue = self.SelectedTabColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SelectedTabColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateSelectedTabColorTo", transform, callback, length, easing);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
