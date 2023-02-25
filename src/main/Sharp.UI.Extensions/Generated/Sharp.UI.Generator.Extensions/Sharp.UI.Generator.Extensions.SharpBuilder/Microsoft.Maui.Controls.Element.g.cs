﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ElementExtension
    {
        public static T AutomationId<T>(this T obj,
            string automationId)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.AutomationIdProperty, automationId);
            return obj;
        }
        
        public static T AutomationId<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.AutomationIdProperty, builder.GetValue());
            return obj;
        }
        
        public static T AutomationId<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.Element.AutomationIdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            string classId)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.ClassIdProperty, classId);
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.ClassIdProperty, builder.GetValue());
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, Microsoft.Maui.Controls.Element.ClassIdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Effects<T>(this T obj,
            IList<Microsoft.Maui.Controls.Effect> effects)
            where T : Microsoft.Maui.Controls.Element
        {
            foreach (var item in effects)
                obj.Effects.Add(item);
            return obj;
        }

        public static T Effects<T>(this T obj,
            params Microsoft.Maui.Controls.Effect[] effects)
            where T : Microsoft.Maui.Controls.Element
        {
            foreach (var item in effects)
                obj.Effects.Add(item);
            return obj;
        }
        
        public static T StyleId<T>(this T obj,
            string styleId)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property StyleId");
            obj.StyleId = styleId;
            return obj;
        }
        
        public static T StyleId<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property StyleId");
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.StyleId = builder.GetValue();
            return obj;
        }
        
        public static T Parent<T>(this T obj,
            Microsoft.Maui.Controls.Element parent)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Parent");
            obj.Parent = parent;
            return obj;
        }
        
        public static T Parent<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Element>, ValueBuilder<Microsoft.Maui.Controls.Element>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Parent");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Element>());
            if (builder.ValueIsSet()) obj.Parent = builder.GetValue();
            return obj;
        }
        
        public static T EffectControlProvider<T>(this T obj,
            Microsoft.Maui.Controls.IEffectControlProvider effectControlProvider)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property EffectControlProvider");
            obj.EffectControlProvider = effectControlProvider;
            return obj;
        }
        
        public static T EffectControlProvider<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IEffectControlProvider>, ValueBuilder<Microsoft.Maui.Controls.IEffectControlProvider>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property EffectControlProvider");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.IEffectControlProvider>());
            if (builder.ValueIsSet()) obj.EffectControlProvider = builder.GetValue();
            return obj;
        }
        
        public static T OnChildAdded<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ChildAdded += handler;
            return obj;
        }
        
        public static T OnChildAdded<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ChildAdded += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnChildRemoved<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ChildRemoved += handler;
            return obj;
        }
        
        public static T OnChildRemoved<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ChildRemoved += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDescendantAdded<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.DescendantAdded += handler;
            return obj;
        }
        
        public static T OnDescendantAdded<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.DescendantAdded += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDescendantRemoved<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.DescendantRemoved += handler;
            return obj;
        }
        
        public static T OnDescendantRemoved<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.DescendantRemoved += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnParentChanging<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ParentChanging += handler;
            return obj;
        }
        
        public static T OnParentChanging<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ParentChanging += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnParentChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ParentChanged += handler;
            return obj;
        }
        
        public static T OnParentChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.ParentChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnHandlerChanging<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.HandlerChanging += handler;
            return obj;
        }
        
        public static T OnHandlerChanging<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.HandlerChanging += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnHandlerChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.HandlerChanged += handler;
            return obj;
        }
        
        public static T OnHandlerChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.HandlerChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T AutomationId<T>(this T obj,
            object automationId)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.AutomationIdProperty, automationId);
            return obj;
        }
        
        public static T AutomationId<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.AutomationIdProperty, builder.GetValue());
            return obj;
        }
        
        public static T AutomationId<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Element.AutomationIdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            object classId)
            where T : Microsoft.Maui.Controls.Element
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.ClassIdProperty, classId);
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Element.ClassIdProperty, builder.GetValue());
            return obj;
        }
        
        public static T ClassId<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.Element
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.Element.ClassIdProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
