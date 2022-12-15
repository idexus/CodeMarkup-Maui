﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class ScrollView : Microsoft.Maui.Controls.ScrollView, Sharp.UI.IScrollView, IEnumerable, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.ScrollView MauiObject { get => this; }

        // ----- constructors -----

        public ScrollView() { }

        public ScrollView(out ScrollView scrollView) 
        {
            scrollView = this;
        }

        public ScrollView(System.Action<ScrollView> configure) 
        {
            configure(this);
        }

        public ScrollView(out ScrollView scrollView, System.Action<ScrollView> configure) 
        {
            scrollView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = MauiWrapper.Value<Microsoft.Maui.Controls.View>(content);

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set => base.BindingContext = MauiWrapper.Value<object>(value);           
        }
        

    }
}

#pragma warning restore CS8669
