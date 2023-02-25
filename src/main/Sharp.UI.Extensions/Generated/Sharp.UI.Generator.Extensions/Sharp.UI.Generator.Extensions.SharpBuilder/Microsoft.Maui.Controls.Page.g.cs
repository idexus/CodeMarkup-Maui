﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class PageExtension
    {
        public static T BackgroundImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource backgroundImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty, backgroundImageSource);
            return obj;
        }
        
        public static T BackgroundImageSource<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T BackgroundImageSource<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.IconImageSourceProperty, iconImageSource);
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.IconImageSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.Page.IconImageSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            bool isBusy)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.IsBusyProperty, isBusy);
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.IsBusyProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsBusy<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Page.IsBusyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.Page.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string title)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.TitleProperty, title);
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Page.TitleProperty, builder.GetValue());
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.Page
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.Page.TitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ToolbarItems<T>(this T obj,
            IList<Microsoft.Maui.Controls.ToolbarItem> toolbarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in toolbarItems)
                obj.ToolbarItems.Add(item);
            return obj;
        }

        public static T ToolbarItems<T>(this T obj,
            params Microsoft.Maui.Controls.ToolbarItem[] toolbarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in toolbarItems)
                obj.ToolbarItems.Add(item);
            return obj;
        }
        
        public static T MenuBarItems<T>(this T obj,
            IList<Microsoft.Maui.Controls.MenuBarItem> menuBarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in menuBarItems)
                obj.MenuBarItems.Add(item);
            return obj;
        }

        public static T MenuBarItems<T>(this T obj,
            params Microsoft.Maui.Controls.MenuBarItem[] menuBarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in menuBarItems)
                obj.MenuBarItems.Add(item);
            return obj;
        }
        
        public static T ContainerArea<T>(this T obj,
            Microsoft.Maui.Graphics.Rect containerArea)
            where T : Microsoft.Maui.Controls.Page
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property ContainerArea");
            obj.ContainerArea = containerArea;
            return obj;
        }
        
        public static T ContainerArea<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property ContainerArea");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) obj.ContainerArea = builder.GetValue();
            return obj;
        }
        
        public static T IgnoresContainerArea<T>(this T obj,
            bool ignoresContainerArea)
            where T : Microsoft.Maui.Controls.Page
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IgnoresContainerArea");
            obj.IgnoresContainerArea = ignoresContainerArea;
            return obj;
        }
        
        public static T IgnoresContainerArea<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Page
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IgnoresContainerArea");
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.IgnoresContainerArea = builder.GetValue();
            return obj;
        }
        
        public static T InternalChildren<T>(this T obj,
            IList<Microsoft.Maui.Controls.Element> internalChildren)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in internalChildren)
                obj.InternalChildren.Add(item);
            return obj;
        }

        public static T InternalChildren<T>(this T obj,
            params Microsoft.Maui.Controls.Element[] internalChildren)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in internalChildren)
                obj.InternalChildren.Add(item);
            return obj;
        }
        
        public static T OnNavigatedTo<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.NavigatedToEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatedTo += handler;
            return obj;
        }
        
        public static T OnNavigatedTo<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatedTo += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnNavigatingFrom<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.NavigatingFromEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatingFrom += handler;
            return obj;
        }
        
        public static T OnNavigatingFrom<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatingFrom += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnNavigatedFrom<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.NavigatedFromEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatedFrom += handler;
            return obj;
        }
        
        public static T OnNavigatedFrom<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.NavigatedFrom += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnLayoutChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.LayoutChanged += handler;
            return obj;
        }
        
        public static T OnLayoutChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.LayoutChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.Appearing += handler;
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.Appearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.Disappearing += handler;
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            obj.Disappearing += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
