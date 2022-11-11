namespace StefansDinner;

public class Human : IDinnerGuest
{
    public Human(string name)
    {
        Name = name;
    }

    private int Level { get; set; }
    public string Name { get; set; }
    private int Counter { get; set; }

    public void Act()
    {
        var items = new[] { "rapar", "äter", "dricker", "pratar" };

        var choosenAction = items[Game.Random.Next(items.Length)];

        if (choosenAction == "rapar") Counter++;
        else Counter = 0;

        Console.WriteLine($"{Name} {choosenAction}      (på raken): [{Counter}]");
    }

    public void MightLevelUp()
    {
        if (Counter == 3) Level++;
        Console.WriteLine($"{Name} Level: {Level}");
    }
}