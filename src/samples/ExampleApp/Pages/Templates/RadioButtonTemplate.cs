﻿using Microsoft.Maui.Controls.Shapes;

namespace ExampleApp
{
    using Sharp.UI;

    public class RadioButtonTemplate : ContentView
    {
        public RadioButtonTemplate()
        {
            Content = new Frame
            {
                new Grid {
                    new Grid()
                    {
                        new Ellipse()
                            .Stroke(Colors.Blue)
                            .Fill(Colors.Wheat)
                            .SizeRequest(16,16)
                            .CenterHorizontally()
                            .CenterVertically(),

                        new Ellipse()
                            .RegisterName("Check", scopedElement: this)
                            .Fill(Colors.Yellow)
                            .SizeRequest(12,12)
                            .CenterHorizontally()
                            .CenterVertically()
                    }
                    .WidthRequest(18)
                    .HeightRequest(10)
                    .HorizontalOptions(LayoutOptions.End)
                    .VerticalOptions(LayoutOptions.Start),

                    new ContentPresenter()
                        .SizeRequest(80,80)
                }
                .Margin(4)
                .WidthRequest(100)
            }
            .BorderColor(AppColors.Gray900)
            .BackgroundColor(AppColors.Gray900)
            .HasShadow(false)
            .SizeRequest(100, 100)
            .VerticalOptions(LayoutOptions.Start)
            .HorizontalOptions(LayoutOptions.Start)
            .Padding(0)
            .Margin(5);

            this.VisualStateGroups(new VisualStateGroupList
            {
                new VisualState()
                    .Name(VisualStates.RadioButton.Checked)
                    .Setters(
                        new Setters<VisualElement>(e => e.BackgroundColor(Colors.Red)),
                        new Setters<Ellipse>(e => e.Fill(Colors.Red)).TargetName("Check")
                    ),

                new VisualState()
                    .Name(VisualStates.RadioButton.Unchecked)
                    .Setters(
                        new Setters<VisualElement>(e => e.BackgroundColor(Colors.Blue)),
                        new Setters<Ellipse>(e => e.Fill(Colors.Yellow)).TargetName("Check")
                    )
            });
        }
    }
}
