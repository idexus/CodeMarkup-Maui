﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class CompareStateTriggerExtension
    {
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            object property)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty, property);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            object value)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty, value);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
