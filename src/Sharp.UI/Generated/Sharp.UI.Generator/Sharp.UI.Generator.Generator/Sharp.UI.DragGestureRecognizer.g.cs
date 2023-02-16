﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.DragGestureRecognizer</c> class.
    /// </summary>
    public partial class DragGestureRecognizer : Microsoft.Maui.Controls.DragGestureRecognizer, Sharp.UI.IDragGestureRecognizer, IMauiWrapper
    {
        // ----- constructors -----

        public DragGestureRecognizer() { }

        public DragGestureRecognizer(out DragGestureRecognizer dragGestureRecognizer) 
        {
            dragGestureRecognizer = this;
        }

        // ----- properties / events -----

        public new object DropCompletedCommandParameter { get => base.DropCompletedCommandParameter; set => base.DropCompletedCommandParameter = MauiWrapper.Value<object>(value); }
        public new object DragStartingCommandParameter { get => base.DragStartingCommandParameter; set => base.DragStartingCommandParameter = MauiWrapper.Value<object>(value); }
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
