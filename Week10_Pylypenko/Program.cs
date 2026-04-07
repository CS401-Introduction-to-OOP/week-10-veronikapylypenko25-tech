namespace Week10_Pylypenko;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Party party = new Party();
        party.Add(new Character("C1", "idk", 3, 55, 500, CharacterStatus.Active));
        party.Add(new Character("C2", "idk2", 6, 5, 10, CharacterStatus.Dead));
        EventLog log = new EventLog();
        log.Add(new MyEvent(1, "Start fight", EventType.Fight, "Nothing changes"));
        log.Add(new MyEvent(2, "Found gold", EventType.Fight, "+120 gold"));
        log.Add(new MyEvent(3, "Death", EventType.Death, "Character died("));

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Show all charachters:");
            Console.WriteLine("2. Show all active charachters:");
            Console.WriteLine("3. Show low level of HP charachters:");
            Console.WriteLine("4. Show all events");
            Console.WriteLine("5. Show events by type:");
            Console.WriteLine("6. LINQ: high level characters");
            Console.WriteLine("7. LINQ: sorting by HP level");
            Console.WriteLine("8. LINQ: statistics");
            Console.WriteLine("0. EXIT:");
            Console.WriteLine("Choose: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (var c in party) Console.WriteLine(c);
                    break;
                case "2":
                    foreach (var c in party.GetActiveCharacters())
                        Console.WriteLine(c);
                    break;
                case "3":
                    Console.WriteLine("Write your HP limit: ");
                    int hp = int.Parse(Console.ReadLine());
                    foreach (var c in party.GetLowHP(hp))
                        Console.WriteLine(c);
                    break;
                case "4":
                    foreach (var ev in log)
                        Console.WriteLine(ev);
                    break;
                case "5":
                    Console.WriteLine("Write Fight,  FoundGold, Healing, LevelUp or  Death: ");
                    string type_ = Console.ReadLine();
                    if (Enum.TryParse(type_, out EventType type))
                    {
                        foreach (var ev in log.GetEventBuType(type))
                            Console.WriteLine(ev);
                    }
                    else
                    {
                        Console.WriteLine("Write correct type!!!!");
                    }

                    break;
                case "6":
                    var hightLev = party.Where(c => c.Level > 3);
                    foreach (var c in hightLev)
                    {
                        Console.WriteLine(c);
                    }break;
                case "7":
                    var s = party.OrderBy(c => c.Welbeeing);
                    foreach (var c in s) Console.WriteLine(c);
                    break;
                case "8":
Console.WriteLine($"Count: {party.Count()}");
Console.WriteLine($"Max gold: {party.Max(c=>c.Gold)}");
Console.WriteLine($"Average HP: {party.Average(c=>c.Welbeeing)}");
                    break;
            case "0": running = false;
                    break;
            default:Console.WriteLine("No option");
                break;
            }
        }
    }
}
