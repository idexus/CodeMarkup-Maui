﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.AdaptiveTrigger</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class AdaptiveTrigger : Sharp.UI.IAdaptiveTrigger, IMauiWrapper, ISealedMauiWrapper
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.AdaptiveTrigger MauiObject { get => (Microsoft.Maui.Controls.AdaptiveTrigger)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public AdaptiveTrigger(Microsoft.Maui.Controls.AdaptiveTrigger adaptiveTrigger)
        {
            MauiObject = adaptiveTrigger;
        }

        public AdaptiveTrigger()
        {
            MauiObject = new Microsoft.Maui.Controls.AdaptiveTrigger();
        }

        public AdaptiveTrigger(out AdaptiveTrigger adaptiveTrigger) : this()
        {
            adaptiveTrigger = this;
        }

        // ----- operators -----

        public static implicit operator AdaptiveTrigger(Microsoft.Maui.Controls.AdaptiveTrigger mauiObject) => new AdaptiveTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.AdaptiveTrigger(AdaptiveTrigger obj) => obj.MauiObject;

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty MinWindowHeightProperty => Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty;
        public static Microsoft.Maui.Controls.BindableProperty MinWindowWidthProperty => Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public double MinWindowHeight { get => MauiObject.MinWindowHeight; set => MauiObject.MinWindowHeight = value; }
        public double MinWindowWidth { get => MauiObject.MinWindowWidth; set => MauiObject.MinWindowWidth = value; }
        public bool IsActive { get => MauiObject.IsActive; }
        public bool IsAttached { get => MauiObject.IsAttached; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.EventHandler IsActiveChanged { add => MauiObject.IsActiveChanged += value; remove => MauiObject.IsActiveChanged -= value; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }

        // ----- set value method -----

        public void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(property, mauiValue);
        }

        public void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
