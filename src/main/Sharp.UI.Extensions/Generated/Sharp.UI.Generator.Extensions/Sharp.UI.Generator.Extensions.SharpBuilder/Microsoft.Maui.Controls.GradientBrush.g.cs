﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    using Sharp.UI.Internal;

    public static partial class GradientBrushExtension
    {
        public static T GradientStops<T>(this T obj,
            IList<Microsoft.Maui.Controls.GradientStop> gradientStops)
            where T : Microsoft.Maui.Controls.GradientBrush
        {
            foreach (var item in gradientStops)
                obj.GradientStops.Add(item);
            return obj;
        }

        public static T GradientStops<T>(this T obj,
            params Microsoft.Maui.Controls.GradientStop[] gradientStops)
            where T : Microsoft.Maui.Controls.GradientBrush
        {
            foreach (var item in gradientStops)
                obj.GradientStops.Add(item);
            return obj;
        }
        
        public static T GradientStops<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>, BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>> buidBinding)
            where T : Microsoft.Maui.Controls.GradientBrush
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.GradientStopCollection>(obj, Microsoft.Maui.Controls.GradientBrush.GradientStopsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnInvalidateGradientBrushRequested<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.GradientBrush
        {
            obj.InvalidateGradientBrushRequested += handler;
            return obj;
        }
        
        public static T OnInvalidateGradientBrushRequested<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GradientBrush
        {
            obj.InvalidateGradientBrushRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
