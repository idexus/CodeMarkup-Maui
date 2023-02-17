﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.LinearGradientBrush</c> class.
    /// </summary>
    public partial class LinearGradientBrush : Microsoft.Maui.Controls.LinearGradientBrush, Sharp.UI.ILinearGradientBrush, IMauiWrapper, IList<Microsoft.Maui.Controls.GradientStop>
    {
        // ----- constructors -----

        public LinearGradientBrush() { }

        public LinearGradientBrush(out LinearGradientBrush linearGradientBrush) 
        {
            linearGradientBrush = this;
        }

        public LinearGradientBrush(System.Action<LinearGradientBrush> configure) 
        {
            configure(this);
        }

        public LinearGradientBrush(out LinearGradientBrush linearGradientBrush, System.Action<LinearGradientBrush> configure) 
        {
            linearGradientBrush = this;
            configure(this);
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, out LinearGradientBrush linearGradientBrush) : this(startPoint, endPoint)
        {
            linearGradientBrush = this;
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, System.Action<LinearGradientBrush> configure) : this(startPoint, endPoint)
        {
            configure(this);
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, out LinearGradientBrush linearGradientBrush, System.Action<LinearGradientBrush> configure) : this(startPoint, endPoint)
        {
            linearGradientBrush = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.GradientStops.Count;
        public Microsoft.Maui.Controls.GradientStop this[int index] { get => this.GradientStops[index]; set => this.GradientStops[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.GradientStops.Clear();
        public bool Contains(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.GradientStop[] array, int arrayIndex) => this.GradientStops.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.GradientStop> GetEnumerator() => this.GradientStops.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Remove(item);
        public void RemoveAt(int index) => this.GradientStops.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.GradientStops.GetEnumerator();

        public void Add(Func<Sharp.UI.LinearGradientBrush, Sharp.UI.LinearGradientBrush> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.GradientStop gradientStop) => this.GradientStops.Add(gradientStop);

        public void Add(Action<IList<Microsoft.Maui.Controls.GradientStop>> builder)
        {
            List<Microsoft.Maui.Controls.GradientStop> items = new List<Microsoft.Maui.Controls.GradientStop>();
            builder(items);
            foreach (var item in items)
                this.GradientStops.Add(item);
        }

        // ----- properties / events -----

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
