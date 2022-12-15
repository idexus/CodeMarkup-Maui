﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class IndicatorView : Microsoft.Maui.Controls.IndicatorView, Sharp.UI.IIndicatorView, IEnumerable, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.IndicatorView MauiObject { get => this; }

        // ----- constructors -----

        public IndicatorView() { }

        public IndicatorView(out IndicatorView indicatorView) 
        {
            indicatorView = this;
        }

        public IndicatorView(System.Action<IndicatorView> configure) 
        {
            configure(this);
        }

        public IndicatorView(out IndicatorView indicatorView, System.Action<IndicatorView> configure) 
        {
            indicatorView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.IndicatorLayout; }

        public void Add(Microsoft.Maui.Controls.IBindableLayout indicatorlayout) => this.IndicatorLayout = MauiWrapper.Value<Microsoft.Maui.Controls.IBindableLayout>(indicatorlayout);

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set => base.BindingContext = MauiWrapper.Value<object>(value);           
        }
        

    }
}

#pragma warning restore CS8669
