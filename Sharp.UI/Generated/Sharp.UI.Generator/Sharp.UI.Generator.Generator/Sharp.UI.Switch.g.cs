﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Switch : Microsoft.Maui.Controls.Switch, Sharp.UI.ISwitch, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.Switch MauiObject { get => this; }

        // ----- constructors -----

        public Switch() { }

        public Switch(out Switch @switch) 
        {
            @switch = this;
        }

        public Switch(System.Action<Switch> configure) 
        {
            configure(this);
        }

        public Switch(out Switch @switch, System.Action<Switch> configure) 
        {
            @switch = this;
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
