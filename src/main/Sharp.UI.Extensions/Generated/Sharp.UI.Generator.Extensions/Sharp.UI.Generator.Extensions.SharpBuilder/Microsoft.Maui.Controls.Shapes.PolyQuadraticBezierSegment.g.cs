﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    using Sharp.UI.Internal;

    public static partial class PolyQuadraticBezierSegmentExtension
    {
        public static T Points<T>(this T obj,
            IList<Microsoft.Maui.Graphics.Point> points)
            where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }

        public static T Points<T>(this T obj,
            params Microsoft.Maui.Graphics.Point[] points)
            where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
        {
            foreach (var item in points)
                obj.Points.Add(item);
            return obj;
        }
        
        public static T Points<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(obj, Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment.PointsProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
