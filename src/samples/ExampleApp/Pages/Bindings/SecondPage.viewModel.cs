﻿namespace ExampleApp;

using Sharp.UI;

[BindableProperties]
public interface ISecondPageViewModelProperties
{
    [DefaultValue("no title")]
    public string Title { get; set; }
    public string Author { get; set; }
}

[SharpObject]
public partial class SecondPageViewModel : BindableObject, ISecondPageViewModelProperties
{
    public void SetAuthor(Button button)
    {
        this.Title = "Tosca";
        this.Author = "Puccini";
    }
}
