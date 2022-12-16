﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class that inherits from the <c>Microsoft.Maui.Controls.Tab</c> class.
    /// </summary>
    public partial class Tab : Microsoft.Maui.Controls.Tab, Sharp.UI.ITab, IMauiWrapper, IList<Microsoft.Maui.Controls.ShellContent>
    {
        // ----- maui object -----

        public Sharp.UI.Tab MauiObject { get => this; }

        // ----- constructors -----

        public Tab() { }

        public Tab(out Tab tab) 
        {
            tab = this;
        }

        public Tab(System.Action<Tab> configure) 
        {
            configure(this);
        }

        public Tab(out Tab tab, System.Action<Tab> configure) 
        {
            tab = this;
            configure(this);
        }

        public Tab(string title) 
        {  
            this.Title = title;
        }

        public Tab(string title, out Tab tab) 
        {  
            this.Title = title;;
            tab = this;
        }

        public Tab(string title, System.Action<Tab> configure) 
        {  
            this.Title = title;
            configure(this);
        }

        public Tab(string title, out Tab tab, System.Action<Tab> configure) 
        {  
            this.Title = title;
            tab = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellContent this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.ShellContent item) => this.Items.Add(item);
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellContent item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellContent[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellContent> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellContent item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellContent item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellContent item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
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
