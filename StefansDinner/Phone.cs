namespace StefansDinner;

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