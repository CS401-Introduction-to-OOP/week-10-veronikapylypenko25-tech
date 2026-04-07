namespace Week10_Pylypenko;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 

public class EventLog:IEnumerable<MyEvent>
{
    private readonly List<MyEvent> _events = new List<MyEvent>();

    public void Add(MyEvent eventGame)
    {
        _events.Add(eventGame);
    }

    public IEnumerator<MyEvent> GetEnumerator()
    {
        foreach (var e in _events)
        {
            yield return e;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<MyEvent> GetActiveCharacters()
    {
        foreach (var eventGame  in _events.OrderBy(e=>e.Number))
        {
                yield return eventGame; 
            
        }
    }

    public IEnumerable<MyEvent> GetEventBuType(EventType type){

        foreach (var eventGame in _events)
        {
            if (eventGame.EventType == type)
            {
                yield return eventGame; 
            }
        }
    }
    public IEnumerable<MyEvent> GetLastEvents(int count)
    {
        int st = Math.Max(0, _events.Count-count); 
        for (int i=st; i<_events.Count;i++)
        {
            yield return _events[i];
        }
    }
}