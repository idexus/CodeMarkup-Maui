﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ItemsViewGeneratedExtension
    {
        public static T EmptyView<T>(this T obj,
            object? emptyView)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (emptyView != null) mauiObject.EmptyView = (object)emptyView;
            return obj;
        }
        
        public static T EmptyView<T>(this T obj,
            object? emptyView,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (emptyView != null) mauiObject.EmptyView = (object)emptyView;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ItemsView.EmptyViewProperty));
            if (def.ValueIsSet()) mauiObject.EmptyView = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EmptyView<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ItemsView.EmptyViewProperty));
            if (def.ValueIsSet()) mauiObject.EmptyView = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? emptyViewTemplate)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (emptyViewTemplate != null) mauiObject.EmptyViewTemplate = (Microsoft.Maui.Controls.DataTemplate)emptyViewTemplate;
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? emptyViewTemplate,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (emptyViewTemplate != null) mauiObject.EmptyViewTemplate = (Microsoft.Maui.Controls.DataTemplate)emptyViewTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty));
            if (def.ValueIsSet()) mauiObject.EmptyViewTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty));
            if (def.ValueIsSet()) mauiObject.EmptyViewTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EmptyViewTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.EmptyViewTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IEnumerable? itemsSource)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (itemsSource != null) mauiObject.ItemsSource = (System.Collections.IEnumerable)itemsSource;
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Collections.IEnumerable? itemsSource,
            System.Func<BindableDef<System.Collections.IEnumerable>, BindableDef<System.Collections.IEnumerable>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (itemsSource != null) mauiObject.ItemsSource = (System.Collections.IEnumerable)itemsSource;
            var def = definition(new BindableDef<System.Collections.IEnumerable>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty));
            if (def.ValueIsSet()) mauiObject.ItemsSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemsSource<T>(this T obj,
            System.Func<BindableDef<System.Collections.IEnumerable>, BindableDef<System.Collections.IEnumerable>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<System.Collections.IEnumerable>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty));
            if (def.ValueIsSet()) mauiObject.ItemsSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Windows.Input.ICommand? remainingItemsThresholdReachedCommand)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (remainingItemsThresholdReachedCommand != null) mauiObject.RemainingItemsThresholdReachedCommand = (System.Windows.Input.ICommand)remainingItemsThresholdReachedCommand;
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Windows.Input.ICommand? remainingItemsThresholdReachedCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (remainingItemsThresholdReachedCommand != null) mauiObject.RemainingItemsThresholdReachedCommand = (System.Windows.Input.ICommand)remainingItemsThresholdReachedCommand;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThresholdReachedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThresholdReachedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            object? remainingItemsThresholdReachedCommandParameter)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (remainingItemsThresholdReachedCommandParameter != null) mauiObject.RemainingItemsThresholdReachedCommandParameter = (object)remainingItemsThresholdReachedCommandParameter;
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            object? remainingItemsThresholdReachedCommandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (remainingItemsThresholdReachedCommandParameter != null) mauiObject.RemainingItemsThresholdReachedCommandParameter = (object)remainingItemsThresholdReachedCommandParameter;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThresholdReachedCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThresholdReachedCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility? horizontalScrollBarVisibility)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (horizontalScrollBarVisibility != null) mauiObject.HorizontalScrollBarVisibility = (Microsoft.Maui.ScrollBarVisibility)horizontalScrollBarVisibility;
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility? horizontalScrollBarVisibility,
            System.Func<BindableDef<Microsoft.Maui.ScrollBarVisibility>, BindableDef<Microsoft.Maui.ScrollBarVisibility>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (horizontalScrollBarVisibility != null) mauiObject.HorizontalScrollBarVisibility = (Microsoft.Maui.ScrollBarVisibility)horizontalScrollBarVisibility;
            var def = definition(new BindableDef<Microsoft.Maui.ScrollBarVisibility>(mauiObject, Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalScrollBarVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.ScrollBarVisibility>, BindableDef<Microsoft.Maui.ScrollBarVisibility>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.ScrollBarVisibility>(mauiObject, Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalScrollBarVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility? verticalScrollBarVisibility)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (verticalScrollBarVisibility != null) mauiObject.VerticalScrollBarVisibility = (Microsoft.Maui.ScrollBarVisibility)verticalScrollBarVisibility;
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility? verticalScrollBarVisibility,
            System.Func<BindableDef<Microsoft.Maui.ScrollBarVisibility>, BindableDef<Microsoft.Maui.ScrollBarVisibility>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (verticalScrollBarVisibility != null) mauiObject.VerticalScrollBarVisibility = (Microsoft.Maui.ScrollBarVisibility)verticalScrollBarVisibility;
            var def = definition(new BindableDef<Microsoft.Maui.ScrollBarVisibility>(mauiObject, Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.VerticalScrollBarVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.ScrollBarVisibility>, BindableDef<Microsoft.Maui.ScrollBarVisibility>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.ScrollBarVisibility>(mauiObject, Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.VerticalScrollBarVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            int? remainingItemsThreshold)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (remainingItemsThreshold != null) mauiObject.RemainingItemsThreshold = (int)remainingItemsThreshold;
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            int? remainingItemsThreshold,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (remainingItemsThreshold != null) mauiObject.RemainingItemsThreshold = (int)remainingItemsThreshold;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThreshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RemainingItemsThreshold<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty));
            if (def.ValueIsSet()) mauiObject.RemainingItemsThreshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? itemTemplate)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (itemTemplate != null) mauiObject.ItemTemplate = (Microsoft.Maui.Controls.DataTemplate)itemTemplate;
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? itemTemplate,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (itemTemplate != null) mauiObject.ItemTemplate = (Microsoft.Maui.Controls.DataTemplate)itemTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ItemTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ItemTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.ItemTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            Microsoft.Maui.Controls.ItemsUpdatingScrollMode? itemsUpdatingScrollMode)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            if (itemsUpdatingScrollMode != null) mauiObject.ItemsUpdatingScrollMode = (Microsoft.Maui.Controls.ItemsUpdatingScrollMode)itemsUpdatingScrollMode;
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            Microsoft.Maui.Controls.ItemsUpdatingScrollMode? itemsUpdatingScrollMode,
            System.Func<BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);         
            if (itemsUpdatingScrollMode != null) mauiObject.ItemsUpdatingScrollMode = (Microsoft.Maui.Controls.ItemsUpdatingScrollMode)itemsUpdatingScrollMode;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty));
            if (def.ValueIsSet()) mauiObject.ItemsUpdatingScrollMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> definition)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(mauiObject, Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty));
            if (def.ValueIsSet()) mauiObject.ItemsUpdatingScrollMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestEventArgs> handler)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.ScrollToRequested += handler;
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.ScrollToRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ItemsViewScrolledEventArgs> handler)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.Scrolled += handler;
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.Scrolled += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.RemainingItemsThresholdReached += handler;
            return obj;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ItemsView>(obj);
            mauiObject.RemainingItemsThresholdReached += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
