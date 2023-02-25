﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class IndicatorViewExtension
    {
        public static T IndicatorsShape<T>(this T obj,
            Microsoft.Maui.Controls.IndicatorShape indicatorsShape)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, indicatorsShape);
            return obj;
        }
        
        public static T IndicatorsShape<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IndicatorShape>, ValueBuilder<Microsoft.Maui.Controls.IndicatorShape>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.IndicatorShape>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorsShape<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.IndicatorShape>, BindingBuilder<Microsoft.Maui.Controls.IndicatorShape>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.IndicatorShape>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorLayout<T>(this T obj,
            Microsoft.Maui.Controls.IBindableLayout indicatorLayout)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IndicatorLayout");
            obj.IndicatorLayout = indicatorLayout;
            return obj;
        }
        
        public static T IndicatorLayout<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>, ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IndicatorLayout");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>());
            if (builder.ValueIsSet()) obj.IndicatorLayout = builder.GetValue();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            int position)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.PositionProperty, position);
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.PositionProperty, builder.GetValue());
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.IndicatorView.PositionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Count<T>(this T obj,
            int count)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.CountProperty, count);
            return obj;
        }
        
        public static T Count<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.CountProperty, builder.GetValue());
            return obj;
        }
        
        public static T Count<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.IndicatorView.CountProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            int maximumVisible)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, maximumVisible);
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate indicatorTemplate)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, indicatorTemplate);
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.IndicatorTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            bool hideSingle)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, hideSingle);
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, builder.GetValue());
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.IndicatorView.HideSingleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color indicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, indicatorColor);
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateIndicatorColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.IndicatorColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.IndicatorColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateIndicatorColorTo", transform, callback, length, easing);
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color selectedIndicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, selectedIndicatorColor);
            return obj;
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateSelectedIndicatorColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.SelectedIndicatorColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SelectedIndicatorColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateSelectedIndicatorColorTo", transform, callback, length, easing);
        }
        
        public static T IndicatorSize<T>(this T obj,
            double indicatorSize)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, indicatorSize);
            return obj;
        }
        
        public static T IndicatorSize<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorSize<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateIndicatorSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            double fromValue = self.IndicatorSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.IndicatorSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateIndicatorSizeTo", transform, callback, length, easing);
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty, itemsSource);
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.IEnumerable>, ValueBuilder<System.Collections.IEnumerable>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<System.Collections.IEnumerable>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<BindingBuilder<System.Collections.IEnumerable>, BindingBuilder<System.Collections.IEnumerable>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<System.Collections.IEnumerable>(obj, Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorsShape<T>(this T obj,
            object indicatorsShape)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, indicatorsShape);
            return obj;
        }
        
        public static T IndicatorsShape<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorsShape<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Position<T>(this T obj,
            object position)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.PositionProperty, position);
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.PositionProperty, builder.GetValue());
            return obj;
        }
        
        public static T Position<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.PositionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Count<T>(this T obj,
            object count)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.CountProperty, count);
            return obj;
        }
        
        public static T Count<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.CountProperty, builder.GetValue());
            return obj;
        }
        
        public static T Count<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.CountProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            object maximumVisible)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, maximumVisible);
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T MaximumVisible<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            object indicatorTemplate)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, indicatorTemplate);
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorTemplate<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            object hideSingle)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, hideSingle);
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, builder.GetValue());
            return obj;
        }
        
        public static T HideSingle<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.HideSingleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            object indicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, indicatorColor);
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            object selectedIndicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, selectedIndicatorColor);
            return obj;
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T SelectedIndicatorColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IndicatorSize<T>(this T obj,
            object indicatorSize)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, indicatorSize);
            return obj;
        }
        
        public static T IndicatorSize<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T IndicatorSize<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            object itemsSource)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty, itemsSource);
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
