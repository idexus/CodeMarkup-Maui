﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ShellSectionGeneratedExtension
    {
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellContent? currentItem)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);
            if (currentItem != null) mauiObject.CurrentItem = (Microsoft.Maui.Controls.ShellContent)currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellContent? currentItem,
            System.Func<BindableDef<Microsoft.Maui.Controls.ShellContent>, BindableDef<Microsoft.Maui.Controls.ShellContent>> definition)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);         
            if (currentItem != null) mauiObject.CurrentItem = (Microsoft.Maui.Controls.ShellContent)currentItem;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ShellContent>(mauiObject, Microsoft.Maui.Controls.ShellSection.CurrentItemProperty));
            if (def.ValueIsSet()) mauiObject.CurrentItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ShellContent>, BindableDef<Microsoft.Maui.Controls.ShellContent>> definition)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ShellContent>(mauiObject, Microsoft.Maui.Controls.ShellSection.CurrentItemProperty));
            if (def.ValueIsSet()) mauiObject.CurrentItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Items<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent> items)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);
            foreach (var item in items)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(item);
                mauiObject.Items.Add(mauiItem);
            }
            return obj;
        }

        public static T Items<T>(this T obj,
            params Microsoft.Maui.Controls.ShellContent[] items)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);
            foreach (var item in items)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(item);
                mauiObject.Items.Add(mauiItem);
            }
            return obj;
        }

        public static T Items<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>> definition)
            where T : Sharp.UI.IShellSection
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellSection>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.ShellContent>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(item);
                    mauiObject.Items.Add(mauiItem);
                }
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
