﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.Shapes.Polygon</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class Polygon : Sharp.UI.IPolygon, IMauiWrapper, ISealedMauiWrapper, IList<Microsoft.Maui.Graphics.Point>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.Shapes.Polygon MauiObject { get => (Microsoft.Maui.Controls.Shapes.Polygon)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public Polygon(Microsoft.Maui.Controls.Shapes.Polygon polygon)
        {
            MauiObject = polygon;
        }

        public Polygon()
        {
            MauiObject = new Microsoft.Maui.Controls.Shapes.Polygon();
        }

        public Polygon(out Polygon polygon) : this()
        {
            polygon = this;
        }

        public Polygon(System.Action<Polygon> configure) : this()
        {
            configure(this);
        }

        public Polygon(out Polygon polygon, System.Action<Polygon> configure) : this()
        {
            polygon = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator Polygon(Microsoft.Maui.Controls.Shapes.Polygon mauiObject) => new Polygon(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.Shapes.Polygon(Polygon obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Points.Count;
        public Microsoft.Maui.Graphics.Point this[int index] { get => this.MauiObject.Points[index]; set => this.MauiObject.Points[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Graphics.Point item) => this.MauiObject.Points.Add(item);
        public void Clear() => this.MauiObject.Points.Clear();
        public bool Contains(Microsoft.Maui.Graphics.Point item) => this.MauiObject.Points.Contains(item);
        public void CopyTo(Microsoft.Maui.Graphics.Point[] array, int arrayIndex) => this.MauiObject.Points.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Graphics.Point> GetEnumerator() => this.MauiObject.Points.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Graphics.Point item) => this.MauiObject.Points.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Graphics.Point item) => this.MauiObject.Points.Insert(index, item);
        public bool Remove(Microsoft.Maui.Graphics.Point item) => this.MauiObject.Points.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.Points.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.Points.GetEnumerator();

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty PointsProperty => Microsoft.Maui.Controls.Shapes.Polygon.PointsProperty;
        public static Microsoft.Maui.Controls.BindableProperty FillRuleProperty => Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty;
        public static Microsoft.Maui.Controls.BindableProperty FillProperty => Microsoft.Maui.Controls.Shapes.Shape.FillProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeThicknessProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeDashArrayProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeDashArrayProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeDashOffsetProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeLineCapProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeLineJoinProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty;
        public static Microsoft.Maui.Controls.BindableProperty StrokeMiterLimitProperty => Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty;
        public static Microsoft.Maui.Controls.BindableProperty AspectProperty => Microsoft.Maui.Controls.Shapes.Shape.AspectProperty;
        public static Microsoft.Maui.Controls.BindableProperty VerticalOptionsProperty => Microsoft.Maui.Controls.View.VerticalOptionsProperty;
        public static Microsoft.Maui.Controls.BindableProperty HorizontalOptionsProperty => Microsoft.Maui.Controls.View.HorizontalOptionsProperty;
        public static Microsoft.Maui.Controls.BindableProperty MarginProperty => Microsoft.Maui.Controls.View.MarginProperty;
        public static Microsoft.Maui.Controls.BindableProperty ShadowProperty => Microsoft.Maui.Controls.VisualElement.ShadowProperty;
        public static Microsoft.Maui.Controls.BindableProperty ZIndexProperty => Microsoft.Maui.Controls.VisualElement.ZIndexProperty;
        public static Microsoft.Maui.Controls.BindableProperty NavigationProperty => Microsoft.Maui.Controls.VisualElement.NavigationProperty;
        public static Microsoft.Maui.Controls.BindableProperty StyleProperty => Microsoft.Maui.Controls.VisualElement.StyleProperty;
        public static Microsoft.Maui.Controls.BindableProperty InputTransparentProperty => Microsoft.Maui.Controls.VisualElement.InputTransparentProperty;
        public static Microsoft.Maui.Controls.BindableProperty IsEnabledProperty => Microsoft.Maui.Controls.VisualElement.IsEnabledProperty;
        public static Microsoft.Maui.Controls.BindableProperty XProperty => Microsoft.Maui.Controls.VisualElement.XProperty;
        public static Microsoft.Maui.Controls.BindableProperty YProperty => Microsoft.Maui.Controls.VisualElement.YProperty;
        public static Microsoft.Maui.Controls.BindableProperty AnchorXProperty => Microsoft.Maui.Controls.VisualElement.AnchorXProperty;
        public static Microsoft.Maui.Controls.BindableProperty AnchorYProperty => Microsoft.Maui.Controls.VisualElement.AnchorYProperty;
        public static Microsoft.Maui.Controls.BindableProperty TranslationXProperty => Microsoft.Maui.Controls.VisualElement.TranslationXProperty;
        public static Microsoft.Maui.Controls.BindableProperty TranslationYProperty => Microsoft.Maui.Controls.VisualElement.TranslationYProperty;
        public static Microsoft.Maui.Controls.BindableProperty WidthProperty => Microsoft.Maui.Controls.VisualElement.WidthProperty;
        public static Microsoft.Maui.Controls.BindableProperty HeightProperty => Microsoft.Maui.Controls.VisualElement.HeightProperty;
        public static Microsoft.Maui.Controls.BindableProperty RotationProperty => Microsoft.Maui.Controls.VisualElement.RotationProperty;
        public static Microsoft.Maui.Controls.BindableProperty RotationXProperty => Microsoft.Maui.Controls.VisualElement.RotationXProperty;
        public static Microsoft.Maui.Controls.BindableProperty RotationYProperty => Microsoft.Maui.Controls.VisualElement.RotationYProperty;
        public static Microsoft.Maui.Controls.BindableProperty ScaleProperty => Microsoft.Maui.Controls.VisualElement.ScaleProperty;
        public static Microsoft.Maui.Controls.BindableProperty ScaleXProperty => Microsoft.Maui.Controls.VisualElement.ScaleXProperty;
        public static Microsoft.Maui.Controls.BindableProperty ScaleYProperty => Microsoft.Maui.Controls.VisualElement.ScaleYProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClipProperty => Microsoft.Maui.Controls.VisualElement.ClipProperty;
        public static Microsoft.Maui.Controls.BindableProperty VisualProperty => Microsoft.Maui.Controls.VisualElement.VisualProperty;
        public static Microsoft.Maui.Controls.BindableProperty IsVisibleProperty => Microsoft.Maui.Controls.VisualElement.IsVisibleProperty;
        public static Microsoft.Maui.Controls.BindableProperty OpacityProperty => Microsoft.Maui.Controls.VisualElement.OpacityProperty;
        public static Microsoft.Maui.Controls.BindableProperty BackgroundColorProperty => Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty;
        public static Microsoft.Maui.Controls.BindableProperty BackgroundProperty => Microsoft.Maui.Controls.VisualElement.BackgroundProperty;
        public static Microsoft.Maui.Controls.BindableProperty BehaviorsProperty => Microsoft.Maui.Controls.VisualElement.BehaviorsProperty;
        public static Microsoft.Maui.Controls.BindableProperty TriggersProperty => Microsoft.Maui.Controls.VisualElement.TriggersProperty;
        public static Microsoft.Maui.Controls.BindableProperty WidthRequestProperty => Microsoft.Maui.Controls.VisualElement.WidthRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty HeightRequestProperty => Microsoft.Maui.Controls.VisualElement.HeightRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty MinimumWidthRequestProperty => Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty MinimumHeightRequestProperty => Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty MaximumWidthRequestProperty => Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty MaximumHeightRequestProperty => Microsoft.Maui.Controls.VisualElement.MaximumHeightRequestProperty;
        public static Microsoft.Maui.Controls.BindableProperty IsFocusedProperty => Microsoft.Maui.Controls.VisualElement.IsFocusedProperty;
        public static Microsoft.Maui.Controls.BindableProperty FlowDirectionProperty => Microsoft.Maui.Controls.VisualElement.FlowDirectionProperty;
        public static Microsoft.Maui.Controls.BindableProperty WindowProperty => Microsoft.Maui.Controls.VisualElement.WindowProperty;
        public static Microsoft.Maui.Controls.BindableProperty AutomationIdProperty => Microsoft.Maui.Controls.Element.AutomationIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClassIdProperty => Microsoft.Maui.Controls.Element.ClassIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.Controls.PointCollection Points { get => MauiObject.Points; set => MauiObject.Points = value; }
        public Microsoft.Maui.Controls.Shapes.FillRule FillRule { get => MauiObject.FillRule; set => MauiObject.FillRule = value; }
        public Microsoft.Maui.Controls.Brush Fill { get => MauiObject.Fill; set => MauiObject.Fill = value; }
        public Microsoft.Maui.Controls.Brush Stroke { get => MauiObject.Stroke; set => MauiObject.Stroke = value; }
        public double StrokeThickness { get => MauiObject.StrokeThickness; set => MauiObject.StrokeThickness = value; }
        public Microsoft.Maui.Controls.DoubleCollection StrokeDashArray { get => MauiObject.StrokeDashArray; set => MauiObject.StrokeDashArray = value; }
        public double StrokeDashOffset { get => MauiObject.StrokeDashOffset; set => MauiObject.StrokeDashOffset = value; }
        public Microsoft.Maui.Controls.Shapes.PenLineCap StrokeLineCap { get => MauiObject.StrokeLineCap; set => MauiObject.StrokeLineCap = value; }
        public Microsoft.Maui.Controls.Shapes.PenLineJoin StrokeLineJoin { get => MauiObject.StrokeLineJoin; set => MauiObject.StrokeLineJoin = value; }
        public double StrokeMiterLimit { get => MauiObject.StrokeMiterLimit; set => MauiObject.StrokeMiterLimit = value; }
        public Microsoft.Maui.Controls.Stretch Aspect { get => MauiObject.Aspect; set => MauiObject.Aspect = value; }
        public float[] StrokeDashPattern { get => MauiObject.StrokeDashPattern; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.IGestureRecognizer> GestureRecognizers { get => MauiObject.GestureRecognizers; }
        public Microsoft.Maui.Controls.LayoutOptions HorizontalOptions { get => MauiObject.HorizontalOptions; set => MauiObject.HorizontalOptions = value; }
        public Microsoft.Maui.Thickness Margin { get => MauiObject.Margin; set => MauiObject.Margin = value; }
        public Microsoft.Maui.Controls.LayoutOptions VerticalOptions { get => MauiObject.VerticalOptions; set => MauiObject.VerticalOptions = value; }
        public Microsoft.Maui.Graphics.Rect Frame { get => MauiObject.Frame; set => MauiObject.Frame = value; }
        public Microsoft.Maui.Controls.Shadow Shadow { get => MauiObject.Shadow; set => MauiObject.Shadow = value; }
        public int ZIndex { get => MauiObject.ZIndex; set => MauiObject.ZIndex = value; }
        public Microsoft.Maui.Graphics.Size DesiredSize { get => MauiObject.DesiredSize; }
        public bool IsLoaded { get => MauiObject.IsLoaded; }
        public Microsoft.Maui.Controls.IVisual Visual { get => MauiObject.Visual; set => MauiObject.Visual = value; }
        public Microsoft.Maui.FlowDirection FlowDirection { get => MauiObject.FlowDirection; set => MauiObject.FlowDirection = value; }
        public Microsoft.Maui.Controls.Window Window { get => MauiObject.Window; }
        public double AnchorX { get => MauiObject.AnchorX; set => MauiObject.AnchorX = value; }
        public double AnchorY { get => MauiObject.AnchorY; set => MauiObject.AnchorY = value; }
        public Microsoft.Maui.Graphics.Color BackgroundColor { get => MauiObject.BackgroundColor; set => MauiObject.BackgroundColor = value; }
        public Microsoft.Maui.Controls.Brush Background { get => MauiObject.Background; set => MauiObject.Background = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior> Behaviors { get => MauiObject.Behaviors; }
        public Microsoft.Maui.Graphics.Rect Bounds { get => MauiObject.Bounds; }
        public double Height { get => MauiObject.Height; }
        public double HeightRequest { get => MauiObject.HeightRequest; set => MauiObject.HeightRequest = value; }
        public bool InputTransparent { get => MauiObject.InputTransparent; set => MauiObject.InputTransparent = value; }
        public bool IsEnabled { get => MauiObject.IsEnabled; set => MauiObject.IsEnabled = value; }
        public bool IsFocused { get => MauiObject.IsFocused; }
        public bool IsVisible { get => MauiObject.IsVisible; set => MauiObject.IsVisible = value; }
        public double MinimumHeightRequest { get => MauiObject.MinimumHeightRequest; set => MauiObject.MinimumHeightRequest = value; }
        public double MinimumWidthRequest { get => MauiObject.MinimumWidthRequest; set => MauiObject.MinimumWidthRequest = value; }
        public double MaximumHeightRequest { get => MauiObject.MaximumHeightRequest; set => MauiObject.MaximumHeightRequest = value; }
        public double MaximumWidthRequest { get => MauiObject.MaximumWidthRequest; set => MauiObject.MaximumWidthRequest = value; }
        public double Opacity { get => MauiObject.Opacity; set => MauiObject.Opacity = value; }
        public double Rotation { get => MauiObject.Rotation; set => MauiObject.Rotation = value; }
        public double RotationX { get => MauiObject.RotationX; set => MauiObject.RotationX = value; }
        public double RotationY { get => MauiObject.RotationY; set => MauiObject.RotationY = value; }
        public double Scale { get => MauiObject.Scale; set => MauiObject.Scale = value; }
        public double ScaleX { get => MauiObject.ScaleX; set => MauiObject.ScaleX = value; }
        public double ScaleY { get => MauiObject.ScaleY; set => MauiObject.ScaleY = value; }
        public double TranslationX { get => MauiObject.TranslationX; set => MauiObject.TranslationX = value; }
        public double TranslationY { get => MauiObject.TranslationY; set => MauiObject.TranslationY = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase> Triggers { get => MauiObject.Triggers; }
        public double Width { get => MauiObject.Width; }
        public double WidthRequest { get => MauiObject.WidthRequest; set => MauiObject.WidthRequest = value; }
        public double X { get => MauiObject.X; }
        public double Y { get => MauiObject.Y; }
        public Microsoft.Maui.Controls.Shapes.Geometry Clip { get => MauiObject.Clip; set => MauiObject.Clip = value; }
        public bool Batched { get => MauiObject.Batched; }
        public bool DisableLayout { get => MauiObject.DisableLayout; set => MauiObject.DisableLayout = value; }
        public bool IsInPlatformLayout { get => MauiObject.IsInPlatformLayout; set => MauiObject.IsInPlatformLayout = value; }
        public bool IsPlatformStateConsistent { get => MauiObject.IsPlatformStateConsistent; set => MauiObject.IsPlatformStateConsistent = value; }
        public bool IsPlatformEnabled { get => MauiObject.IsPlatformEnabled; set => MauiObject.IsPlatformEnabled = value; }
        public Microsoft.Maui.Controls.ResourceDictionary Resources { get => MauiObject.Resources; set => MauiObject.Resources = value; }
        public Microsoft.Maui.Controls.INavigation Navigation { get => MauiObject.Navigation; }
        public Sharp.UI.Style Style { get => new Sharp.UI.Style(MauiObject.Style); set => MauiObject.Style = value.MauiObject; }
        public System.Collections.Generic.IList<string> StyleClass { get => MauiObject.StyleClass; set => MauiObject.StyleClass = value; }
        public System.Collections.Generic.IList<string> @class { get => MauiObject.@class; set => MauiObject.@class = value; }
        public Microsoft.Maui.Controls.Internals.NavigationProxy NavigationProxy { get => MauiObject.NavigationProxy; }
        public string AutomationId { get => MauiObject.AutomationId; set => MauiObject.AutomationId = value; }
        public string ClassId { get => MauiObject.ClassId; set => MauiObject.ClassId = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Effect> Effects { get => MauiObject.Effects; }
        public System.Guid Id { get => MauiObject.Id; }
        public string StyleId { get => MauiObject.StyleId; set => MauiObject.StyleId = value; }
        public Microsoft.Maui.Controls.Element RealParent { get => MauiObject.RealParent; }
        public Microsoft.Maui.Controls.Element Parent { get => MauiObject.Parent; set => MauiObject.Parent = value; }
        public Microsoft.Maui.Controls.IEffectControlProvider EffectControlProvider { get => MauiObject.EffectControlProvider; set => MauiObject.EffectControlProvider = value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.EventHandler? Loaded { add => MauiObject.Loaded += value; remove => MauiObject.Loaded -= value; }
        public event System.EventHandler? Unloaded { add => MauiObject.Unloaded += value; remove => MauiObject.Unloaded -= value; }
        public event System.EventHandler ChildrenReordered { add => MauiObject.ChildrenReordered += value; remove => MauiObject.ChildrenReordered -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.FocusEventArgs> Focused { add => MauiObject.Focused += value; remove => MauiObject.Focused -= value; }
        public event System.EventHandler MeasureInvalidated { add => MauiObject.MeasureInvalidated += value; remove => MauiObject.MeasureInvalidated -= value; }
        public event System.EventHandler SizeChanged { add => MauiObject.SizeChanged += value; remove => MauiObject.SizeChanged -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.FocusEventArgs> Unfocused { add => MauiObject.Unfocused += value; remove => MauiObject.Unfocused -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.Internals.EventArg<Microsoft.Maui.Controls.VisualElement>> BatchCommitted { add => MauiObject.BatchCommitted += value; remove => MauiObject.BatchCommitted -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.VisualElement.FocusRequestArgs> FocusChangeRequested { add => MauiObject.FocusChangeRequested += value; remove => MauiObject.FocusChangeRequested -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildAdded { add => MauiObject.ChildAdded += value; remove => MauiObject.ChildAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildRemoved { add => MauiObject.ChildRemoved += value; remove => MauiObject.ChildRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantAdded { add => MauiObject.DescendantAdded += value; remove => MauiObject.DescendantAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantRemoved { add => MauiObject.DescendantRemoved += value; remove => MauiObject.DescendantRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> ParentChanging { add => MauiObject.ParentChanging += value; remove => MauiObject.ParentChanging -= value; }
        public event System.EventHandler ParentChanged { add => MauiObject.ParentChanged += value; remove => MauiObject.ParentChanged -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> HandlerChanging { add => MauiObject.HandlerChanging += value; remove => MauiObject.HandlerChanging -= value; }
        public event System.EventHandler HandlerChanged { add => MauiObject.HandlerChanged += value; remove => MauiObject.HandlerChanged -= value; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }

        // ----- set value method -----

        public void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(property, mauiValue);
        }

        public void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
