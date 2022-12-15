﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class FlexLayout : Microsoft.Maui.Controls.FlexLayout, Sharp.UI.IFlexLayout, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.FlexLayout MauiObject { get => this; }

        // ----- constructors -----

        public FlexLayout() { }

        public FlexLayout(out FlexLayout flexLayout) 
        {
            flexLayout = this;
        }

        public FlexLayout(System.Action<FlexLayout> configure) 
        {
            configure(this);
        }

        public FlexLayout(out FlexLayout flexLayout, System.Action<FlexLayout> configure) 
        {
            flexLayout = this;
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
