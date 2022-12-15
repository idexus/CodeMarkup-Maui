﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class MenuFlyoutSubItem : Microsoft.Maui.Controls.MenuFlyoutSubItem, Sharp.UI.IMenuFlyoutSubItem, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.MenuFlyoutSubItem MauiObject { get => this; }

        // ----- constructors -----

        public MenuFlyoutSubItem() { }

        public MenuFlyoutSubItem(out MenuFlyoutSubItem menuFlyoutSubItem) 
        {
            menuFlyoutSubItem = this;
        }

        public MenuFlyoutSubItem(System.Action<MenuFlyoutSubItem> configure) 
        {
            configure(this);
        }

        public MenuFlyoutSubItem(out MenuFlyoutSubItem menuFlyoutSubItem, System.Action<MenuFlyoutSubItem> configure) 
        {
            menuFlyoutSubItem = this;
            configure(this);
        }

        public MenuFlyoutSubItem(string text) 
        {  
            this.Text = text;
        }

        public MenuFlyoutSubItem(string text, out MenuFlyoutSubItem menuFlyoutSubItem) 
        {  
            this.Text = text;;
            menuFlyoutSubItem = this;
        }

        public MenuFlyoutSubItem(string text, System.Action<MenuFlyoutSubItem> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public MenuFlyoutSubItem(string text, out MenuFlyoutSubItem menuFlyoutSubItem, System.Action<MenuFlyoutSubItem> configure) 
        {  
            this.Text = text;
            menuFlyoutSubItem = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set => base.BindingContext = MauiWrapper.Value<object>(value);           
        }
        

    }
}

#pragma warning restore CS8669
