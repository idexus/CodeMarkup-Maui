﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class PolyLineSegmentExtension
    {
        public static T Points<T>(this T obj,
            IList<Microsoft.Maui.Graphics.Point> points)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }

        public static T Points<T>(this T obj,
            params Microsoft.Maui.Graphics.Point[] points)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }
        
        public static T Points<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(obj, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Points<T>(this T obj,
            object points)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty, points);
            return obj;
        }
        
        public static T Points<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty, builder.GetValue());
            return obj;
        }
        
        public static T Points<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
