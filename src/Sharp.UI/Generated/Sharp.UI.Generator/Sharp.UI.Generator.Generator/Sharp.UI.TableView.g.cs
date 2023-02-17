﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.TableView</c> class.
    /// </summary>
    public partial class TableView : Microsoft.Maui.Controls.TableView, Sharp.UI.ITableView, IMauiWrapper, IList<Microsoft.Maui.Controls.TableSection>
    {
        // ----- constructors -----

        public TableView(out TableView tableView) : this()
        {
            tableView = this;
        }

        public TableView(System.Action<TableView> configure) : this()
        {
            configure(this);
        }

        public TableView(out TableView tableView, System.Action<TableView> configure) : this()
        {
            tableView = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Root.Count;
        public Microsoft.Maui.Controls.TableSection this[int index] { get => this.Root[index]; set => this.Root[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Root.Clear();
        public bool Contains(Microsoft.Maui.Controls.TableSection item) => this.Root.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.TableSection[] array, int arrayIndex) => this.Root.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.TableSection> GetEnumerator() => this.Root.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.TableSection item) => this.Root.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.TableSection item) => this.Root.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.TableSection item) => this.Root.Remove(item);
        public void RemoveAt(int index) => this.Root.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Root.GetEnumerator();

        public void Add(Func<Sharp.UI.TableView, Sharp.UI.TableView> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.TableSection tableSection) => this.Root.Add(tableSection);

        public void Add(Action<IList<Microsoft.Maui.Controls.TableSection>> builder)
        {
            List<Microsoft.Maui.Controls.TableSection> items = new List<Microsoft.Maui.Controls.TableSection>();
            builder(items);
            foreach (var item in items)
                this.Root.Add(item);
        }

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
