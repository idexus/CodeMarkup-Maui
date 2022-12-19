﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class GroupableItemsViewGeneratedExtension
    {
        public static T IsGrouped<T>(this T obj,
            bool? isGrouped)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            if (isGrouped != null) mauiObject.IsGrouped = (bool)isGrouped;
            return obj;
        }
        
        public static T IsGrouped<T>(this T obj,
            bool? isGrouped,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);         
            if (isGrouped != null) mauiObject.IsGrouped = (bool)isGrouped;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.IsGroupedProperty));
            if (def.ValueIsSet()) mauiObject.IsGrouped = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsGrouped<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.IsGroupedProperty));
            if (def.ValueIsSet()) mauiObject.IsGrouped = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? groupHeaderTemplate)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            if (groupHeaderTemplate != null) mauiObject.GroupHeaderTemplate = (Microsoft.Maui.Controls.DataTemplate)groupHeaderTemplate;
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? groupHeaderTemplate,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);         
            if (groupHeaderTemplate != null) mauiObject.GroupHeaderTemplate = (Microsoft.Maui.Controls.DataTemplate)groupHeaderTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.GroupHeaderTemplateProperty));
            if (def.ValueIsSet()) mauiObject.GroupHeaderTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.GroupHeaderTemplateProperty));
            if (def.ValueIsSet()) mauiObject.GroupHeaderTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            mauiObject.GroupHeaderTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T GroupFooterTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? groupFooterTemplate)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            if (groupFooterTemplate != null) mauiObject.GroupFooterTemplate = (Microsoft.Maui.Controls.DataTemplate)groupFooterTemplate;
            return obj;
        }
        
        public static T GroupFooterTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? groupFooterTemplate,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);         
            if (groupFooterTemplate != null) mauiObject.GroupFooterTemplate = (Microsoft.Maui.Controls.DataTemplate)groupFooterTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.GroupFooterTemplateProperty));
            if (def.ValueIsSet()) mauiObject.GroupFooterTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupFooterTemplate<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.GroupableItemsView.GroupFooterTemplateProperty));
            if (def.ValueIsSet()) mauiObject.GroupFooterTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GroupFooterTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IGroupableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GroupableItemsView>(obj);
            mauiObject.GroupFooterTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
