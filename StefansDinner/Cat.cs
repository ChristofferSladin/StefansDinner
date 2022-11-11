namespace StefansDinner;

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

        if (act < 10 && Outside == false) 
        {
            Console.WriteLine("Hur kom katten IN?");
        }
        if (act > 10 && act < 20 && Outside == true)
        {
            Console.WriteLine("What!? Vem släppte IN katten?");
        }
    }
    public void MightLevelUp()
    {

    }
}