﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class RefreshView : Microsoft.Maui.Controls.RefreshView, Sharp.UI.IRefreshView, IEnumerable, IWrappedBindableObject
    {
        // ----- maui object -----

        public Sharp.UI.RefreshView MauiObject { get => this; }

        // ----- constructors -----

        public RefreshView() { }

        public RefreshView(out RefreshView refreshView) 
        {
            refreshView = this;
        }

        public RefreshView(System.Action<RefreshView> configure) 
        {
            configure(this);
        }

        public RefreshView(out RefreshView refreshView, System.Action<RefreshView> configure) 
        {
            refreshView = this;
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
