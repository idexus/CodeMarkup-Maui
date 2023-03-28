﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class EllipseGeometryExtension
    {
        public static T Center<T>(this T self,
            Microsoft.Maui.Graphics.Point center)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty, center);
            return self;
        }
        
        public static T Center<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Center<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Point center)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty, Value = center });
            return self;
        }
        
        public static SettersContext<T> Center<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T RadiusX<T>(this T self,
            double radiusX)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, radiusX);
            return self;
        }
        
        public static T RadiusX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> RadiusX<T>(this SettersContext<T> self,
            double radiusX)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, Value = radiusX });
            return self;
        }
        
        public static SettersContext<T> RadiusX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty);
            configure(context).Build();
            return self;
        }
        
        public static T RadiusY<T>(this T self,
            double radiusY)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, radiusY);
            return self;
        }
        
        public static T RadiusY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> RadiusY<T>(this SettersContext<T> self,
            double radiusY)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, Value = radiusY });
            return self;
        }
        
        public static SettersContext<T> RadiusY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
