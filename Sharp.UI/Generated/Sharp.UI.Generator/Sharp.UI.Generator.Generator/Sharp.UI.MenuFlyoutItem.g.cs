﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.MenuFlyoutItem</c> class.
    /// </summary>
    public partial class MenuFlyoutItem : Microsoft.Maui.Controls.MenuFlyoutItem, Sharp.UI.IMenuFlyoutItem, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.MenuFlyoutItem MauiObject { get => this; }

        // ----- constructors -----

        public MenuFlyoutItem() { }

        public MenuFlyoutItem(out MenuFlyoutItem menuFlyoutItem) 
        {
            menuFlyoutItem = this;
        }

        public MenuFlyoutItem(System.Action<MenuFlyoutItem> configure) 
        {
            configure(this);
        }

        public MenuFlyoutItem(out MenuFlyoutItem menuFlyoutItem, System.Action<MenuFlyoutItem> configure) 
        {
            menuFlyoutItem = this;
            configure(this);
        }

        public MenuFlyoutItem(string text, out MenuFlyoutItem menuFlyoutItem) : this(text)
        {
            menuFlyoutItem = this;
        }

        public MenuFlyoutItem(string text, System.Action<MenuFlyoutItem> configure) : this(text)
        {
            configure(this);
        }

        public MenuFlyoutItem(string text, out MenuFlyoutItem menuFlyoutItem, System.Action<MenuFlyoutItem> configure) : this(text)
        {
            menuFlyoutItem = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object CommandParameter { get => base.CommandParameter; set => base.CommandParameter = MauiWrapper.Value<object>(value); }
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
