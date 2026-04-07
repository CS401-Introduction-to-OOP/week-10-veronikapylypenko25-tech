namespace Week10_Pylypenko;

using System.Collections;
using System.Collections.Generic;
public enum EventType
{
    Fight, 
    FoundGold,
    Healing, 
    LevelUp,
    Death
}
public class MyEvent
{
    public int Number { get; set; }
    public string Description { get; set; }
    public EventType EventType { get; set; }
    public string StatusChange { get; set; }

    public MyEvent(int number, string description, EventType eventType, string statusChange)
    {
        Number = number;
        Description = description;
        EventType = eventType;
        StatusChange = statusChange;
    }
    public override string ToString()
    {
        return $"Number: {Number}, description: {Description},type of event: {EventType}, {StatusChange}.";
    }
}