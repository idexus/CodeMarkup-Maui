﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class CellExtension
    {
        public static T ContextActions<T>(this T obj,
            IList<Microsoft.Maui.Controls.MenuItem> contextActions)
            where T : Microsoft.Maui.Controls.Cell
        {
            foreach (var item in contextActions)
                obj.ContextActions.Add(item);
            return obj;
        }

        public static T ContextActions<T>(this T obj,
            params Microsoft.Maui.Controls.MenuItem[] contextActions)
            where T : Microsoft.Maui.Controls.Cell
        {
            foreach (var item in contextActions)
                obj.ContextActions.Add(item);
            return obj;
        }
        
        public static T IsContextActionsLegacyModeEnabled<T>(this T obj,
            bool isContextActionsLegacyModeEnabled)
            where T : Microsoft.Maui.Controls.Cell
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IsContextActionsLegacyModeEnabled");
            obj.IsContextActionsLegacyModeEnabled = isContextActionsLegacyModeEnabled;
            return obj;
        }
        
        public static T IsContextActionsLegacyModeEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Cell
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IsContextActionsLegacyModeEnabled");
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IsContextActionsLegacyModeEnabled = builder.GetValue();
            return obj;
        }
        
        public static T Height<T>(this T obj,
            double height)
            where T : Microsoft.Maui.Controls.Cell
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Height");
            obj.Height = height;
            return obj;
        }
        
        public static T Height<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Cell
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Height");
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.Height = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Cell.IsEnabledProperty, isEnabled);
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Cell
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Cell.IsEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Cell
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Cell.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Appearing += handler;
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Appearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Disappearing += handler;
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Disappearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnForceUpdateSizeRequested<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.ForceUpdateSizeRequested += handler;
            return obj;
        }
        
        public static T OnForceUpdateSizeRequested<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.ForceUpdateSizeRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnTapped<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Tapped += handler;
            return obj;
        }
        
        public static T OnTapped<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Cell
        {
            obj.Tapped += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
