﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class that inherits from the <c>Microsoft.Maui.Controls.Frame</c> class.
    /// </summary>
    public partial class Frame : Microsoft.Maui.Controls.Frame, Sharp.UI.IFrame, IMauiWrapper, IEnumerable
    {
        // ----- maui object -----

        public Sharp.UI.Frame MauiObject { get => this; }

        // ----- constructors -----

        public Frame() { }

        public Frame(out Frame frame) 
        {
            frame = this;
        }

        public Frame(System.Action<Frame> configure) 
        {
            configure(this);
        }

        public Frame(out Frame frame, System.Action<Frame> configure) 
        {
            frame = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

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
