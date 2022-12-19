﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class BindingConditionGeneratedExtension
    {
        public static T Binding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase? binding)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            if (binding != null) mauiObject.Binding = (Microsoft.Maui.Controls.BindingBase)binding;
            return obj;
        }
        
        public static T Binding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase? binding,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindingBase>, ValueDef<Microsoft.Maui.Controls.BindingBase>> definition)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            if (binding != null) mauiObject.Binding = (Microsoft.Maui.Controls.BindingBase)binding;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindingBase>());
            if (def.ValueIsSet()) mauiObject.Binding = def.GetValue();
            return obj;
        }
        
        public static T Binding<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindingBase>, ValueDef<Microsoft.Maui.Controls.BindingBase>> definition)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindingBase>());
            if (def.ValueIsSet()) mauiObject.Binding = def.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            if (value != null) mauiObject.Value = (object)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            if (value != null) mauiObject.Value = (object)value;
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IBindingCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.BindingCondition>(obj);
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
