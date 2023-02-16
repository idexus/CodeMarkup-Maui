﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace ExampleApp
{  
    using Sharp.UI;

    public partial class CustomShadow
    {
        // ----- constructors -----

        public CustomShadow() { }

        public CustomShadow(out CustomShadow customShadow) 
        {
            customShadow = this;
        }

        // ----- attached properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty HasShadowProperty =
            BindableProperty.CreateAttached(
                "HasShadow",
                typeof(bool),
                typeof(ExampleApp.CustomShadow),
                default(bool),
                propertyChanged: OnHasShadowChanged);

        public static bool GetHasShadow(BindableObject obj)
        {
            return (bool)obj.GetValue(HasShadowProperty);
        }

        public static void SetHasShadow(BindableObject obj, bool value)
        {
            obj.SetValue(HasShadowProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty ShadowSizeProperty =
            BindableProperty.CreateAttached(
                "ShadowSize",
                typeof(double),
                typeof(ExampleApp.CustomShadow),
                default(double));

        public static double GetShadowSize(BindableObject obj)
        {
            return (double)obj.GetValue(ShadowSizeProperty);
        }

        public static void SetShadowSize(BindableObject obj, double value)
        {
            obj.SetValue(ShadowSizeProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty ShadowColorProperty =
            BindableProperty.CreateAttached(
                "ShadowColor",
                typeof(Microsoft.Maui.Graphics.Color),
                typeof(ExampleApp.CustomShadow),
                (Microsoft.Maui.Graphics.Color)Colors.Red);

        public static Microsoft.Maui.Graphics.Color GetShadowColor(BindableObject obj)
        {
            return (Microsoft.Maui.Graphics.Color)obj.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(BindableObject obj, Microsoft.Maui.Graphics.Color value)
        {
            obj.SetValue(ShadowColorProperty, value);
        }
        
    }
}

#pragma warning restore CS8669
