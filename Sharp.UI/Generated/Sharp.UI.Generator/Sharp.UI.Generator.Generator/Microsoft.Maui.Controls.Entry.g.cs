﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class EntryGeneratedExtension
    {
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? horizontalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (horizontalTextAlignment != null) mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Entry.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Entry.HorizontalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.HorizontalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment? verticalTextAlignment,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (verticalTextAlignment != null) mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Entry.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.TextAlignment>, BindableDef<Microsoft.Maui.TextAlignment>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.Entry.VerticalTextAlignmentProperty));
            if (def.ValueIsSet()) mauiObject.VerticalTextAlignment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsPassword<T>(this T obj,
            bool? isPassword)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (isPassword != null) mauiObject.IsPassword = (bool)isPassword;
            return obj;
        }
        
        public static T IsPassword<T>(this T obj,
            bool? isPassword,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (isPassword != null) mauiObject.IsPassword = (bool)isPassword;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.IsPasswordProperty));
            if (def.ValueIsSet()) mauiObject.IsPassword = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsPassword<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.IsPasswordProperty));
            if (def.ValueIsSet()) mauiObject.IsPassword = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Entry.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.Entry.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Entry.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.Entry.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Entry.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Entry.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool? isTextPredictionEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (isTextPredictionEnabled != null) mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Entry.IsTextPredictionEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsTextPredictionEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnType<T>(this T obj,
            Microsoft.Maui.ReturnType? returnType)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (returnType != null) mauiObject.ReturnType = (Microsoft.Maui.ReturnType)returnType;
            return obj;
        }
        
        public static T ReturnType<T>(this T obj,
            Microsoft.Maui.ReturnType? returnType,
            System.Func<BindableDef<Microsoft.Maui.ReturnType>, BindableDef<Microsoft.Maui.ReturnType>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (returnType != null) mauiObject.ReturnType = (Microsoft.Maui.ReturnType)returnType;
            var def = definition(new BindableDef<Microsoft.Maui.ReturnType>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnTypeProperty));
            if (def.ValueIsSet()) mauiObject.ReturnType = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnType<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.ReturnType>, BindableDef<Microsoft.Maui.ReturnType>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.ReturnType>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnTypeProperty));
            if (def.ValueIsSet()) mauiObject.ReturnType = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int? cursorPosition,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (cursorPosition != null) mauiObject.CursorPosition = (int)cursorPosition;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Entry.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Entry.CursorPositionProperty));
            if (def.ValueIsSet()) mauiObject.CursorPosition = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int? selectionLength,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (selectionLength != null) mauiObject.SelectionLength = (int)selectionLength;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Entry.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.Entry.SelectionLengthProperty));
            if (def.ValueIsSet()) mauiObject.SelectionLength = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnCommand<T>(this T obj,
            System.Windows.Input.ICommand? returnCommand)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (returnCommand != null) mauiObject.ReturnCommand = (System.Windows.Input.ICommand)returnCommand;
            return obj;
        }
        
        public static T ReturnCommand<T>(this T obj,
            System.Windows.Input.ICommand? returnCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (returnCommand != null) mauiObject.ReturnCommand = (System.Windows.Input.ICommand)returnCommand;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnCommandProperty));
            if (def.ValueIsSet()) mauiObject.ReturnCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnCommandProperty));
            if (def.ValueIsSet()) mauiObject.ReturnCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnCommandParameter<T>(this T obj,
            object? returnCommandParameter)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (returnCommandParameter != null) mauiObject.ReturnCommandParameter = (object)returnCommandParameter;
            return obj;
        }
        
        public static T ReturnCommandParameter<T>(this T obj,
            object? returnCommandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (returnCommandParameter != null) mauiObject.ReturnCommandParameter = (object)returnCommandParameter;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.ReturnCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ReturnCommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.Entry.ReturnCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.ReturnCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ClearButtonVisibility<T>(this T obj,
            Microsoft.Maui.ClearButtonVisibility? clearButtonVisibility)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            if (clearButtonVisibility != null) mauiObject.ClearButtonVisibility = (Microsoft.Maui.ClearButtonVisibility)clearButtonVisibility;
            return obj;
        }
        
        public static T ClearButtonVisibility<T>(this T obj,
            Microsoft.Maui.ClearButtonVisibility? clearButtonVisibility,
            System.Func<BindableDef<Microsoft.Maui.ClearButtonVisibility>, BindableDef<Microsoft.Maui.ClearButtonVisibility>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);         
            if (clearButtonVisibility != null) mauiObject.ClearButtonVisibility = (Microsoft.Maui.ClearButtonVisibility)clearButtonVisibility;
            var def = definition(new BindableDef<Microsoft.Maui.ClearButtonVisibility>(mauiObject, Microsoft.Maui.Controls.Entry.ClearButtonVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.ClearButtonVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ClearButtonVisibility<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.ClearButtonVisibility>, BindableDef<Microsoft.Maui.ClearButtonVisibility>> definition)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.ClearButtonVisibility>(mauiObject, Microsoft.Maui.Controls.Entry.ClearButtonVisibilityProperty));
            if (def.ValueIsSet()) mauiObject.ClearButtonVisibility = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnCompleted<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            mauiObject.Completed += handler;
            return obj;
        }
        
        public static T OnCompleted<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IEntry
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Entry>(obj);
            mauiObject.Completed += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
