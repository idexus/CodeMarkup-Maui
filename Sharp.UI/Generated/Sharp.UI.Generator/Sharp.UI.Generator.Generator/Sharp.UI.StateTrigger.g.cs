﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class StateTrigger : Sharp.UI.IStateTrigger, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.StateTrigger MauiObject { get => (Microsoft.Maui.Controls.StateTrigger)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        protected StateTrigger(Microsoft.Maui.Controls.StateTrigger stateTrigger)
        {
            MauiObject = stateTrigger;
        }

        public StateTrigger()
        {
            MauiObject = new Microsoft.Maui.Controls.StateTrigger();
        }

        public StateTrigger(out StateTrigger stateTrigger) : this()
        {
            stateTrigger = this;
        }

        public StateTrigger(System.Action<StateTrigger> configure) : this()
        {
            configure(this);
        }

        public StateTrigger(out StateTrigger stateTrigger, System.Action<StateTrigger> configure) : this()
        {
            stateTrigger = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator StateTrigger(Microsoft.Maui.Controls.StateTrigger mauiObject) => new StateTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.StateTrigger(StateTrigger obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty IsActiveProperty => Microsoft.Maui.Controls.StateTrigger.IsActiveProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public bool IsActive { get => MauiObject.IsActive; set => MauiObject.IsActive = value; }
        public bool IsAttached { get => MauiObject.IsAttached; }
        public event System.EventHandler IsActiveChanged { add => MauiObject.IsActiveChanged += value; remove => MauiObject.IsActiveChanged -= value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }
        // ----- binding context -----

        public object BindingContext
        {
            get => MauiObject.BindingContext;
            set => MauiObject.BindingContext = MauiWrapper.Value<object>(value);           
        }
        

    }
}

#pragma warning restore CS8669
