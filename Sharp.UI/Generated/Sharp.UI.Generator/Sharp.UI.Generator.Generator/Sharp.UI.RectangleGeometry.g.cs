﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class that inherits from the <c>Microsoft.Maui.Controls.Shapes.RectangleGeometry</c> class.
    /// </summary>
    public partial class RectangleGeometry : Microsoft.Maui.Controls.Shapes.RectangleGeometry, Sharp.UI.IRectangleGeometry, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.RectangleGeometry MauiObject { get => this; }

        // ----- constructors -----

        public RectangleGeometry() { }

        public RectangleGeometry(out RectangleGeometry rectangleGeometry) 
        {
            rectangleGeometry = this;
        }

        public RectangleGeometry(System.Action<RectangleGeometry> configure) 
        {
            configure(this);
        }

        public RectangleGeometry(out RectangleGeometry rectangleGeometry, System.Action<RectangleGeometry> configure) 
        {
            rectangleGeometry = this;
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
