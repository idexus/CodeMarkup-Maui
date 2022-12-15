﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class Border : Microsoft.Maui.Controls.Border, Sharp.UI.IBorder, IEnumerable, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.Border MauiObject { get => this; }

        // ----- constructors -----

        public Border() { }

        public Border(out Border border) 
        {
            border = this;
        }

        public Border(System.Action<Border> configure) 
        {
            configure(this);
        }

        public Border(out Border border, System.Action<Border> configure) 
        {
            border = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View? content) => this.Content = MauiWrapper.Value<Microsoft.Maui.Controls.View?>(content);

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set => base.BindingContext = MauiWrapper.Value<object>(value);           
        }
        

    }
}

#pragma warning restore CS8669
