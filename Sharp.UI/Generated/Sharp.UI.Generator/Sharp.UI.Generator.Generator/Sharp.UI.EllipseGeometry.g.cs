﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Shapes.EllipseGeometry</c> class.
    /// </summary>
    public partial class EllipseGeometry : Microsoft.Maui.Controls.Shapes.EllipseGeometry, Sharp.UI.IEllipseGeometry, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.EllipseGeometry MauiObject { get => this; }

        // ----- constructors -----

        public EllipseGeometry() { }

        public EllipseGeometry(out EllipseGeometry ellipseGeometry) 
        {
            ellipseGeometry = this;
        }

        public EllipseGeometry(System.Action<EllipseGeometry> configure) 
        {
            configure(this);
        }

        public EllipseGeometry(out EllipseGeometry ellipseGeometry, System.Action<EllipseGeometry> configure) 
        {
            ellipseGeometry = this;
            configure(this);
        }

        public EllipseGeometry(double radiusX, double radiusY, Microsoft.Maui.Graphics.Point center, out EllipseGeometry ellipseGeometry) : this(radiusX, radiusY, center)
        {
            ellipseGeometry = this;
        }

        public EllipseGeometry(double radiusX, double radiusY, Microsoft.Maui.Graphics.Point center, System.Action<EllipseGeometry> configure) : this(radiusX, radiusY, center)
        {
            configure(this);
        }

        public EllipseGeometry(double radiusX, double radiusY, Microsoft.Maui.Graphics.Point center, out EllipseGeometry ellipseGeometry, System.Action<EllipseGeometry> configure) : this(radiusX, radiusY, center)
        {
            ellipseGeometry = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
