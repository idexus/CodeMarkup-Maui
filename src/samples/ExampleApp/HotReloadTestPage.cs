﻿using System;
using Microsoft.Maui.Controls.Shapes;

namespace ExampleApp
{
    using System.ComponentModel;
    using Sharp.UI;



    [SharpObject]
    public partial class HotReloadTestPage : ContentPage
    {
        private readonly Button button;

        MyViewModel viewModel => BindingContext as MyViewModel;

        public HotReloadTestPage(MyViewModel viewModel)
        {
            BindingContext = viewModel;
            Resources = new ResourceDictionary
            {
                new Style<Label>(e => e
                    .FontSize(50)
                    .TextColor(Colors.Red)),
            };

            Content = new Grid(e => e.BackgroundColor(Colors.Black))
            {
                new VStack(out var vStack, e => e.VerticalOptions(LayoutOptions.Center))
                {
                    e => e.Configure(e =>
                    {
                        e.Resources = new ResourceDictionary
                        {
                            new Style<Label>(e => e.FontSize(70)),

                            new Style<Button>(e => e
                                .FontSize(40))
                            {
                                new VisualState<Button>(VisualStateEnum.VisualElement.Normal, e => e
                                    .FontSize(40)
                                    .TextColor(Colors.Blue)
                                    .SizeRequest(200,80)),

                                new VisualState<Button>(VisualStateEnum.VisualElement.Disabled, e => e
                                    .FontSize(60)
                                    .TextColor(Colors.Gray)
                                    .SizeRequest(280,130))
                            }
                        };
                    }),

                    new Label("Hot Reload :)")
                        .TextColor(AppColors.Gray500)
                        .HorizontalOptions(LayoutOptions.Center),

                    new Slider(1, 30, 1, out var slider)
                        .Value(e => e.Path("SliderValue"))
                        .Margin(new Thickness(50, 30))
                        .WidthRequest(400)
                        .OnValueChanged(s =>
                        {
                            button.IsEnabled = s.Value < 10;
                        }),
                    
                    new Border(e => e
                        .SizeRequest(270, 430)
                        .Margin(10)
                        .StrokeShape(new RoundRectangle().CornerRadius(40))
                        .BackgroundColor(AppColors.Gray950))
                    {
                        new Grid(e => e.RowDefinitions(e => e.Star().Star(2).Star()))
                        {
                            new Label()
                                .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                                .FontSize(40)
                                .TextColor(Colors.DarkGray)
                                .HorizontalOptions(LayoutOptions.Center)
                                .VerticalOptions(LayoutOptions.Center),

                            new Image("dotnet_bot.png").Row(1),

                            new Label("Hello, World!").Row(2)
                                .FontSize(30)
                                .TextColor(Colors.DarkGray)
                                .HorizontalOptions(LayoutOptions.Center)
                                .VerticalOptions(LayoutOptions.Center),
                        }
                    },

                    new Label()
                        .Text(e => e.Path("Counter").StringFormat("Counter : {0}"))
                        .FontSize(30)
                        .HorizontalOptions(LayoutOptions.Center)
                        .Margin(30),

                    new Button("Click me", out button)
                        .BackgroundColor(AppColors.Gray950)
                        .TextColor(Colors.Yellow)
                        .OnClicked(async (Button sender) =>
                        {
                            viewModel.Count();
                            await vStack.RotateYTo(15, 50);
                            await vStack.RotateYTo(-15, 150);
                            await vStack.RotateYTo(0, 150);
                        })
                }
            };
        }
    }

}