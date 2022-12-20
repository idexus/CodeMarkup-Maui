﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ReorderableItemsViewGeneratedExtension
    {
        public static T CanMixGroups<T>(this T obj,
            bool canMixGroups)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            mauiObject.CanMixGroups = (bool)canMixGroups;
            return obj;
        }
        
        public static T CanMixGroups<T>(this T obj,
            bool canMixGroups,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);         
            mauiObject.CanMixGroups = (bool)canMixGroups;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty));
            if (def.ValueIsSet()) mauiObject.CanMixGroups = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CanMixGroups<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty));
            if (def.ValueIsSet()) mauiObject.CanMixGroups = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            bool canReorderItems)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            mauiObject.CanReorderItems = (bool)canReorderItems;
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            bool canReorderItems,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);         
            mauiObject.CanReorderItems = (bool)canReorderItems;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty));
            if (def.ValueIsSet()) mauiObject.CanReorderItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CanReorderItems<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty));
            if (def.ValueIsSet()) mauiObject.CanReorderItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnReorderCompleted<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            mauiObject.ReorderCompleted += handler;
            return obj;
        }
        
        public static T OnReorderCompleted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IReorderableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ReorderableItemsView>(obj);
            mauiObject.ReorderCompleted += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
