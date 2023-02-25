﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class FileImageSourceExtension
    {
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            string file)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.FileImageSource.FileProperty, file);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.FileImageSource.FileProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.FileImageSource.FileProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            object file)
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.FileImageSource.FileProperty, file);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.FileImageSource.FileProperty, builder.GetValue());
            return obj;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.FileImageSource.FileProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
