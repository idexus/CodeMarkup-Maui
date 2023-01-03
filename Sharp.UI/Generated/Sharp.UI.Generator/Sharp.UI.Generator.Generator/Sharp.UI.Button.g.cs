﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Button</c> class.
    /// </summary>
    public partial class Button : Microsoft.Maui.Controls.Button, Sharp.UI.IButton, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.Button MauiObject { get => this; }

        // ----- constructors -----

        public Button() { }

        public Button(out Button button) 
        {
            button = this;
        }

        public Button(System.Action<Button> configure) 
        {
            configure(this);
        }

        public Button(out Button button, System.Action<Button> configure) 
        {
            button = this;
            configure(this);
        }

        public Button(string text, out Button button) : this(text)
        {
            button = this;
        }

        public Button(string text, System.Action<Button> configure) : this(text)
        {
            configure(this);
        }

        public Button(string text, out Button button, System.Action<Button> configure) : this(text)
        {
            button = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object CommandParameter { get => base.CommandParameter; set => base.CommandParameter = MauiWrapper.Value<object>(value); }
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
