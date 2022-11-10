using StefansDinner;

public class App
{
    public void Run()
    {
        var round = 1;
        var game = new Game();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Spelomgång {round}");
            game.Run();
            System.Threading.Thread.Sleep(2000);
            round++;
        }
    }
}