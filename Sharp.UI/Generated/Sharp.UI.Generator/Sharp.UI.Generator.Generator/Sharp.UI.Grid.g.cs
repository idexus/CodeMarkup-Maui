﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Grid</c> class.
    /// </summary>
    public partial class Grid : Microsoft.Maui.Controls.Grid, Sharp.UI.IGrid, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.Grid MauiObject { get => this; }

        // ----- constructors -----

        public Grid() { }

        public Grid(out Grid grid) 
        {
            grid = this;
        }

        public Grid(System.Action<Grid> configure) 
        {
            configure(this);
        }

        public Grid(out Grid grid, System.Action<Grid> configure) 
        {
            grid = this;
            configure(this);
        }

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
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
