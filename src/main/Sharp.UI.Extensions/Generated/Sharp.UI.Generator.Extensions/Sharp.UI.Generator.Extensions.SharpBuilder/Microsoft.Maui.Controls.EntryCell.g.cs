﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class EntryCellExtension
    {
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, builder.GetValue());
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(obj, Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, verticalTextAlignment);
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, builder.GetValue());
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(obj, Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            Microsoft.Maui.Keyboard keyboard)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, keyboard);
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Keyboard>, ValueBuilder<Microsoft.Maui.Keyboard>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Keyboard>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, builder.GetValue());
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Keyboard>, BindingBuilder<Microsoft.Maui.Keyboard>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Keyboard>(obj, Microsoft.Maui.Controls.EntryCell.KeyboardProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Label<T>(this T obj,
            string label)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelProperty, label);
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelProperty, builder.GetValue());
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.EntryCell.LabelProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color labelColor)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, labelColor);
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.EntryCell.LabelColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            string placeholder)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, placeholder);
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, builder.GetValue());
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.EntryCell.PlaceholderProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string text)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.TextProperty, text);
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.TextProperty, builder.GetValue());
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.EntryCell.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnCompleted<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.Completed += handler;
            return obj;
        }
        
        public static T OnCompleted<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.Completed += (o, arg) => action(obj);
            return obj;
        }
        

        public static T CenterTextHorizontally<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Center);
            return obj;
        }

        public static T CenterTextVertically<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Center);
            return obj;
        }

        public static T CenterText<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Center);
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Center);
            return obj;
        }

        public static T AlignTextTop<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Top);
            return obj;
        }

        public static T AlignTextBottom<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell, Microsoft.Maui.ITextAlignment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Bottom);
            return obj;
        }

        public static T AlignTextTopLeft<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Top);
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Left);
            return obj;
        }

        public static T AlignTextBottomLeft<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Bottom);
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Left);
            return obj;
        }

        public static T AlignTextTopRight<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Top);
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Right);
            return obj;
        }

        public static T AlignTextBottomRight<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, VerticalAlignment.Bottom);
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Right);
            return obj;
        }

        public static T AlignTextLeft<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Left);
            return obj;
        }

        public static T AlignTextRight<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Right);
            return obj;
        }

        public static T AlignTextJustified<T>(this T obj)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, HorizontalAlignment.Justified);
            return obj;
        }

        
        public static T Text<T>(this T obj,
            object text)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.TextProperty, text);
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.TextProperty, builder.GetValue());
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Label<T>(this T obj,
            object label)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelProperty, label);
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelProperty, builder.GetValue());
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.LabelProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            object placeholder)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, placeholder);
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, builder.GetValue());
            return obj;
        }
        
        public static T Placeholder<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.PlaceholderProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            object labelColor)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, labelColor);
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T LabelColor<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.LabelColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            object keyboard)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, keyboard);
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, builder.GetValue());
            return obj;
        }
        
        public static T Keyboard<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.KeyboardProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            object horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, builder.GetValue());
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            object verticalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, verticalTextAlignment);
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, builder.GetValue());
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
