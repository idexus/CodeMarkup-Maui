﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class PropertyCondition : Sharp.UI.IPropertyCondition, ISealedMauiWrapper
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.PropertyCondition MauiObject { get => (Microsoft.Maui.Controls.PropertyCondition)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        protected PropertyCondition(Microsoft.Maui.Controls.PropertyCondition propertyCondition)
        {
            MauiObject = propertyCondition;
        }

        public PropertyCondition()
        {
            MauiObject = new Microsoft.Maui.Controls.PropertyCondition();
        }

        public PropertyCondition(out PropertyCondition propertyCondition) : this()
        {
            propertyCondition = this;
        }

        public PropertyCondition(System.Action<PropertyCondition> configure) : this()
        {
            configure(this);
        }

        public PropertyCondition(out PropertyCondition propertyCondition, System.Action<PropertyCondition> configure) : this()
        {
            propertyCondition = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator PropertyCondition(Microsoft.Maui.Controls.PropertyCondition mauiObject) => new PropertyCondition(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.PropertyCondition(PropertyCondition obj) => obj.MauiObject;

        // ----- bindable properties -----


        // ----- properties / events -----

        public Microsoft.Maui.Controls.BindableProperty Property { get => MauiObject.Property; set => MauiObject.Property = value; }
        public object Value { get => MauiObject.Value; set => MauiObject.Value = value; }
    }
}

#pragma warning restore CS8669
