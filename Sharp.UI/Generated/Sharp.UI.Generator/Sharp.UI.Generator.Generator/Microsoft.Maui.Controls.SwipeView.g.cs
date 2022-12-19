﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeViewGeneratedExtension
    {
        public static T Threshold<T>(this T obj,
            double? threshold)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            if (threshold != null) mauiObject.Threshold = (double)threshold;
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            double? threshold,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);         
            if (threshold != null) mauiObject.Threshold = (double)threshold;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SwipeView.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SwipeView.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? leftItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            if (leftItems != null) mauiObject.LeftItems = (Microsoft.Maui.Controls.SwipeItems)leftItems;
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? leftItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);         
            if (leftItems != null) mauiObject.LeftItems = (Microsoft.Maui.Controls.SwipeItems)leftItems;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.LeftItemsProperty));
            if (def.ValueIsSet()) mauiObject.LeftItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.LeftItemsProperty));
            if (def.ValueIsSet()) mauiObject.LeftItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? rightItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            if (rightItems != null) mauiObject.RightItems = (Microsoft.Maui.Controls.SwipeItems)rightItems;
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? rightItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);         
            if (rightItems != null) mauiObject.RightItems = (Microsoft.Maui.Controls.SwipeItems)rightItems;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.RightItemsProperty));
            if (def.ValueIsSet()) mauiObject.RightItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.RightItemsProperty));
            if (def.ValueIsSet()) mauiObject.RightItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? topItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            if (topItems != null) mauiObject.TopItems = (Microsoft.Maui.Controls.SwipeItems)topItems;
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? topItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);         
            if (topItems != null) mauiObject.TopItems = (Microsoft.Maui.Controls.SwipeItems)topItems;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.TopItemsProperty));
            if (def.ValueIsSet()) mauiObject.TopItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.TopItemsProperty));
            if (def.ValueIsSet()) mauiObject.TopItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? bottomItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            if (bottomItems != null) mauiObject.BottomItems = (Microsoft.Maui.Controls.SwipeItems)bottomItems;
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? bottomItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);         
            if (bottomItems != null) mauiObject.BottomItems = (Microsoft.Maui.Controls.SwipeItems)bottomItems;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.BottomItemsProperty));
            if (def.ValueIsSet()) mauiObject.BottomItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.BottomItemsProperty));
            if (def.ValueIsSet()) mauiObject.BottomItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSwipeStarted<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeStartedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeStarted += handler;
            return obj;
        }
        
        public static T OnSwipeStarted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeStarted += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnSwipeChanging<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeChangingEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeChanging += handler;
            return obj;
        }
        
        public static T OnSwipeChanging<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeChanging += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnSwipeEnded<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SwipeEndedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeEnded += handler;
            return obj;
        }
        
        public static T OnSwipeEnded<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeEnded += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnOpenRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.OpenRequestedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.OpenRequested += handler;
            return obj;
        }
        
        public static T OnOpenRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.OpenRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnCloseRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CloseRequestedEventArgs> handler)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.CloseRequested += handler;
            return obj;
        }
        
        public static T OnCloseRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.CloseRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
