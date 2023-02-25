﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class DeviceStateTriggerExtension
    {
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            string device)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, device);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            object device)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, device);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
