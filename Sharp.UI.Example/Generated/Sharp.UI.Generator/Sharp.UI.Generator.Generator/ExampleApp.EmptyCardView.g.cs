﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace ExampleApp
{  
    using Sharp.UI;

    public partial class EmptyCardView
    {
        // ----- constructors -----

        public EmptyCardView() { }

        public EmptyCardView(out EmptyCardView emptyCardView) 
        {
            emptyCardView = this;
        }

        public EmptyCardView(System.Action<EmptyCardView> configure) 
        {
            configure(this);
        }

        public EmptyCardView(out EmptyCardView emptyCardView, System.Action<EmptyCardView> configure) 
        {
            emptyCardView = this;
            configure(this);
        }

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty CardTitleProperty =
            BindableProperty.Create(
                nameof(CardTitle),
                typeof(string),
                typeof(ExampleApp.EmptyCardView),
                default(string));

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }

        public static readonly Microsoft.Maui.Controls.BindableProperty CardDescriptionProperty =
            BindableProperty.Create(
                nameof(CardDescription),
                typeof(string),
                typeof(ExampleApp.EmptyCardView),
                default(string));

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }

        public static readonly Microsoft.Maui.Controls.BindableProperty CardColorProperty =
            BindableProperty.Create(
                nameof(CardColor),
                typeof(Microsoft.Maui.Graphics.Color),
                typeof(ExampleApp.EmptyCardView),
                default(Microsoft.Maui.Graphics.Color));

        public Microsoft.Maui.Graphics.Color CardColor
        {
            get => (Microsoft.Maui.Graphics.Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }

        public static readonly Microsoft.Maui.Controls.BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Microsoft.Maui.Graphics.Color),
                typeof(ExampleApp.EmptyCardView),
                default(Microsoft.Maui.Graphics.Color));

        public Microsoft.Maui.Graphics.Color BorderColor
        {
            get => (Microsoft.Maui.Graphics.Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

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
