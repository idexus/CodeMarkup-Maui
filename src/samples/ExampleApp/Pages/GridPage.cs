﻿
namespace ExampleApp
{
    using Sharp.UI;

    public class GridPage : ContentPage
    {
        public GridPage()
        {
            Content =

            new Grid(out var grid, e => e
                .Margin(top: Shell.Current != null ? 30 : 0)
                .RowSpacing(15)
                .ColumnSpacing(15)
                .Padding(10)
                .RowDefinitions(e => e.Star(2).Star(1).Absolute(100).Absolute(100))
                .ColumnDefinitions(e => e.Star().Star(2)))
            {
                new BoxView().Color(Colors.Red),
                new Label("Column 0, Row 0"),

                new BoxView().Color(Colors.Blue).Column(1).Row(0),
                new Label("Column 1, Row 0").Column(1).Row(0),

                new BoxView().Color(Colors.Teal).Column(0).Row(1),
                new Label("Column 0, Row 1").Column(0).Row(1),

                new BoxView().Color(Colors.Purple).Column(1).Row(1),
                new Label("Column 1, Row 1").Column(1).Row(1),

                new BoxView().Color(Colors.Red).Column(0).Row(2).GridSpan(column: 2),
                new Label("Column 0, Row 2, Span 2 columns").Column(0).Row(2).GridSpan(column: 2),

                new Button("Change background color")
                    .Column(0).Row(3)
                    .ColumnSpan(2)
                    .OnClicked(e =>
                    {
                        grid.BackgroundColor = Colors.DarkRed;
                    })
            };
        }
    }
}
