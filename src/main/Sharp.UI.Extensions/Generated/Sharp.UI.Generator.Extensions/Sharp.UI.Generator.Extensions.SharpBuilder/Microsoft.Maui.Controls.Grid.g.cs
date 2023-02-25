﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class GridExtension
    {
        public static T ColumnDefinitions<T>(this T obj,
            IList<Microsoft.Maui.Controls.ColumnDefinition> columnDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            foreach (var item in columnDefinitions)
                obj.ColumnDefinitions.Add(item);
            return obj;
        }

        public static T ColumnDefinitions<T>(this T obj,
            params Microsoft.Maui.Controls.ColumnDefinition[] columnDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            foreach (var item in columnDefinitions)
                obj.ColumnDefinitions.Add(item);
            return obj;
        }
        
        public static T ColumnDefinitions<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ColumnDefinitionCollection>, BindingBuilder<Microsoft.Maui.Controls.ColumnDefinitionCollection>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ColumnDefinitionCollection>(obj, Microsoft.Maui.Controls.Grid.ColumnDefinitionsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowDefinitions<T>(this T obj,
            IList<Microsoft.Maui.Controls.RowDefinition> rowDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            foreach (var item in rowDefinitions)
                obj.RowDefinitions.Add(item);
            return obj;
        }

        public static T RowDefinitions<T>(this T obj,
            params Microsoft.Maui.Controls.RowDefinition[] rowDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            foreach (var item in rowDefinitions)
                obj.RowDefinitions.Add(item);
            return obj;
        }
        
        public static T RowDefinitions<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.RowDefinitionCollection>, BindingBuilder<Microsoft.Maui.Controls.RowDefinitionCollection>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.RowDefinitionCollection>(obj, Microsoft.Maui.Controls.Grid.RowDefinitionsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            double rowSpacing)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpacingProperty, rowSpacing);
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Grid.RowSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateRowSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Grid
        {
            double fromValue = self.RowSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RowSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRowSpacingTo", transform, callback, length, easing);
        }
        
        public static T ColumnSpacing<T>(this T obj,
            double columnSpacing)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, columnSpacing);
            return obj;
        }
        
        public static T ColumnSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T ColumnSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Grid.ColumnSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateColumnSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Grid
        {
            double fromValue = self.ColumnSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.ColumnSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateColumnSpacingTo", transform, callback, length, easing);
        }
        
        public static T ColumnDefinitions<T>(this T obj,
            object columnDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnDefinitionsProperty, columnDefinitions);
            return obj;
        }
        
        public static T ColumnDefinitions<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnDefinitionsProperty, builder.GetValue());
            return obj;
        }
        
        public static T ColumnDefinitions<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.ColumnDefinitionsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowDefinitions<T>(this T obj,
            object rowDefinitions)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowDefinitionsProperty, rowDefinitions);
            return obj;
        }
        
        public static T RowDefinitions<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowDefinitionsProperty, builder.GetValue());
            return obj;
        }
        
        public static T RowDefinitions<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.RowDefinitionsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            object rowSpacing)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpacingProperty, rowSpacing);
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T RowSpacing<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.RowSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ColumnSpacing<T>(this T obj,
            object columnSpacing)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, columnSpacing);
            return obj;
        }
        
        public static T ColumnSpacing<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, builder.GetValue());
            return obj;
        }
        
        public static T ColumnSpacing<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.ColumnSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Row<T>(this T obj,
            object row)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowProperty, row);
            return obj;
        }
        
        public static T Row<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowProperty, builder.GetValue());
            return obj;
        }
        
        public static T Row<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.RowProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowSpan<T>(this T obj,
            object rowSpan)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpanProperty, rowSpan);
            return obj;
        }
        
        public static T RowSpan<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpanProperty, builder.GetValue());
            return obj;
        }
        
        public static T RowSpan<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.RowSpanProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Column<T>(this T obj,
            object column)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnProperty, column);
            return obj;
        }
        
        public static T Column<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnProperty, builder.GetValue());
            return obj;
        }
        
        public static T Column<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.ColumnProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ColumnSpan<T>(this T obj,
            object columnSpan)
            where T : Microsoft.Maui.Controls.Grid
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, columnSpan);
            return obj;
        }
        
        public static T ColumnSpan<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, builder.GetValue());
            return obj;
        }
        
        public static T ColumnSpan<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Grid
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Grid.ColumnSpanProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
