namespace StefansDinner;

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