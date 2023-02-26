﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ColumnDefinitionExtension
    {
        public static Microsoft.Maui.Controls.ColumnDefinition Width(this Microsoft.Maui.Controls.ColumnDefinition self,
            Microsoft.Maui.GridLength width)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ColumnDefinition.WidthProperty, width);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition Width(this Microsoft.Maui.Controls.ColumnDefinition self,
            System.Func<ValueBuilder<Microsoft.Maui.GridLength>, ValueBuilder<Microsoft.Maui.GridLength>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.GridLength>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ColumnDefinition.WidthProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition Width<TBuilder>(this Microsoft.Maui.Controls.ColumnDefinition self, System.Action<TBuilder> configure)
            where TBuilder : PropertyBuilder<Microsoft.Maui.GridLength>
        {
            var builder = TBuilder(self, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty);
            configure(builder);
            builder.Build();
            return self;
        }

        //public static Microsoft.Maui.Controls.ColumnDefinition Width(this Microsoft.Maui.Controls.ColumnDefinition self,
        //    System.Func<BindingBuilder<Microsoft.Maui.GridLength>, BindingBuilder<Microsoft.Maui.GridLength>> buildBinding)
        //{
        //    var builder = buildBinding(new BindingBuilder<Microsoft.Maui.GridLength>(self, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty));
        //    builder.Build();
        //    return self;
        //}
        
        public static Microsoft.Maui.Controls.ColumnDefinition OnSizeChanged(this Microsoft.Maui.Controls.ColumnDefinition self, System.EventHandler handler)
        {
            self.SizeChanged += handler;
            return self;
        }
        
        public static Microsoft.Maui.Controls.ColumnDefinition OnSizeChanged(this Microsoft.Maui.Controls.ColumnDefinition self, System.Action<Microsoft.Maui.Controls.ColumnDefinition> action)
        {
            self.SizeChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
