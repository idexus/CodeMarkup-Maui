﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class that inherits from the <c>Microsoft.Maui.Controls.RadioButton</c> class.
    /// </summary>
    public partial class RadioButton : Microsoft.Maui.Controls.RadioButton, Sharp.UI.IRadioButton, IMauiWrapper, IEnumerable
    {
        // ----- maui object -----

        public Sharp.UI.RadioButton MauiObject { get => this; }

        // ----- constructors -----

        public RadioButton() { }

        public RadioButton(out RadioButton radioButton) 
        {
            radioButton = this;
        }

        public RadioButton(System.Action<RadioButton> configure) 
        {
            configure(this);
        }

        public RadioButton(out RadioButton radioButton, System.Action<RadioButton> configure) 
        {
            radioButton = this;
            configure(this);
        }

        public RadioButton(object content) 
        {  
            this.Content = content;
        }

        public RadioButton(object content, out RadioButton radioButton) 
        {  
            this.Content = content;;
            radioButton = this;
        }

        public RadioButton(object content, System.Action<RadioButton> configure) 
        {  
            this.Content = content;
            configure(this);
        }

        public RadioButton(object content, out RadioButton radioButton, System.Action<RadioButton> configure) 
        {  
            this.Content = content;
            radioButton = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(object content) => this.Content = content;

        // ----- properties / events -----

        public new object Content { get => base.Content; set => base.Content = MauiWrapper.Value<object>(value); }
        public new object Value { get => base.Value; set => base.Value = MauiWrapper.Value<object>(value); }
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
