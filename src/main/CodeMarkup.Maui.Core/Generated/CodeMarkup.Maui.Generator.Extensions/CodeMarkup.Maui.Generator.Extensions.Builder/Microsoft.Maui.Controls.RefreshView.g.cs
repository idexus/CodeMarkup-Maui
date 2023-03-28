﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class RefreshViewExtension
    {
        public static T IsRefreshing<T>(this T self,
            bool isRefreshing)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.SetValue(Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, isRefreshing);
            return self;
        }
        
        public static T IsRefreshing<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self,
            bool isRefreshing)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, Value = isRefreshing });
            return self;
        }
        
        public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.SetValue(Microsoft.Maui.Controls.RefreshView.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.RefreshView.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Command<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.RefreshView.CommandProperty, Value = command });
            return self;
        }
        
        public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.RefreshView.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.SetValue(Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.RefreshView.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.RefreshView.CommandParameterProperty, Value = commandParameter });
            return self;
        }
        
        public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.RefreshView.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T RefreshColor<T>(this T self,
            Microsoft.Maui.Graphics.Color refreshColor)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.SetValue(Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, refreshColor);
            return self;
        }
        
        public static T RefreshColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> RefreshColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color refreshColor)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, Value = refreshColor });
            return self;
        }
        
        public static SettersContext<T> RefreshColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateRefreshColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.RefreshColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.RefreshColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateRefreshColorTo", transform, callback, length, easing);
        }
        
        public static T OnRefreshing<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.Refreshing += handler;
            return self;
        }
        
        public static T OnRefreshing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.RefreshView
        {
            self.Refreshing += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
