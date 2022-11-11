using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace StefansDinner;

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
        var obj = new JsonGameStorage();
        foreach (IDinnerGuest x in guests)
        {
            x.Act();
            x.MightLevelUp();
            obj.Save(guests);
            obj.Load();
        }

    }
}

