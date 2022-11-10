using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace StefansDinner;

public interface IDinnerGuest
{
    void Act();
    void MightLevelUp();
}
public class Fly : IDinnerGuest
{
    private int Level { get; set; }
    private string Latest { get; set; }

    public void Act()
    {
        var items = new[] { "flyger", "surrar", "landar i maten" };

        var choosenAction = items[Game.Random.Next(items.Length)];

        Console.WriteLine($"Flugan {choosenAction}");

        Latest = choosenAction;
    }

    public void MightLevelUp()
    {
        if (Latest == "landar i maten") Level++;
        Console.WriteLine($"Flugan Level: {Level}");

    }
}

public class Human : IDinnerGuest
{
    private int Level { get; set; }

    public string Name { get; set; }
    private int counter { get; set; }
    public Human(string name)
    {
        Name = name;
    }

    public void Act()
    {
        var items = new[] { "rapar", "äter", "dricker", "pratar" };

        var choosenAction = items[Game.Random.Next(items.Length)];

        if (choosenAction == "rapar") counter++;
        else counter = 0;

        Console.WriteLine($"{Name} {choosenAction}      (på raken): [{counter}]");
    }

    public void MightLevelUp()
    {
        if (counter == 3) Level++;
        Console.WriteLine($"{Name} Level: {Level}");
    }
}

public class Cat : IDinnerGuest
{
    private bool Outside { get; set; }

    public void Act()
    {
        var items = new[] { "Inne", "Ute" };

        var currentState = items[Game.Random.Next(items.Length)];

        int act = Game.Random.Next(0, 100);

        if (currentState == "Inne") Outside = false;
        if (currentState == "Ute") Outside = true;

        if (act < 10 && Outside == false) //katten vill ut
        {
            Console.WriteLine("Hur kom katten Ut?");
        }
        if (act > 10 && act < 20 && Outside == true) // katten vill in
        {
            Console.WriteLine("What!? Vem släppte ut katten?");
        }
    }
    public void MightLevelUp()
    {

    }
}

public class Phone : IDinnerGuest
{
    public void Act()
    {
        int act = Game.Random.Next(0, 100);

        var items = new[] { "Får ett SMS", "Ringer" };

        if (act < 5) Console.WriteLine($"Telefonen {items[0]}");
        if (act > 5 && act < 10) Console.WriteLine($"Telefonen {items[1]}");
    }

    public void MightLevelUp()
    {

    }
}
public class Game
{
    public static Random Random = new Random();

    public List<IDinnerGuest> guests = new List<IDinnerGuest>();

    // public Cat cat = new Cat();
    public Game()
    {
        guests.Add(item: new Human(name: "Chrille"));
        guests.Add(item: new Human(name: "Linnea"));
        guests.Add(item: new Human(name: "Filippa"));
        guests.Add(item: new Fly());
        guests.Add(item: new Phone());
        guests.Add(item: new Cat());
    }
    public void Run()
    {
        foreach (IDinnerGuest x in guests)
        {
            x.Act();
            x.MightLevelUp();
        }
    }
}

