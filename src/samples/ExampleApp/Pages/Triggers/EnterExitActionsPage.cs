﻿namespace ExampleApp;

using Sharp.UI;

public class FadeTriggerAction : TriggerAction<VisualElement>
{
    public int StartsFrom { get; set; }
    public FadeTriggerAction(int startsFrom)
    {
        StartsFrom = startsFrom;
    }

    protected override void Invoke(VisualElement sender)
    {
        sender.Animate("FadeTriggerAction", new Animation((d) =>
        {
            var val = StartsFrom == 1 ? d : 1 - d;
            sender.BackgroundColor = Color.FromRgb(1, val, 1);
        }),
        length: 1000, 
        easing: Easing.Linear);
    }
}

public class EnterExitActionsPage : ContentPage
{
	public EnterExitActionsPage()
	{
        Content = new VStack
        {
            new Entry("Enter text...", out var entry)
                .Text("")
                .BackgroundColor(Colors.White)
                .Triggers(
                    new Trigger(typeof(Entry))
                        .Property(Entry.IsFocusedProperty)
                        .Value(true)                       
                        .EnterActions(new FadeTriggerAction(startsFrom: 0))
                        .ExitActions(new FadeTriggerAction(startsFrom: 1)))
        }
        .CenterVertically();
    }
}
