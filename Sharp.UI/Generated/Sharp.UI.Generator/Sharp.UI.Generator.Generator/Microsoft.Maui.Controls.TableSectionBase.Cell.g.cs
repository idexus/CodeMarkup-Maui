﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TableSectionBaseCellGeneratedExtension
    {
        public static T OnCollectionChanged<T>(this T obj, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
            where T : Sharp.UI.ITableSectionBaseCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TableSectionBase<Microsoft.Maui.Controls.Cell>>(obj);
            mauiObject.CollectionChanged += handler;
            return obj;
        }
        
        public static T OnCollectionChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ITableSectionBaseCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TableSectionBase<Microsoft.Maui.Controls.Cell>>(obj);
            mauiObject.CollectionChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
