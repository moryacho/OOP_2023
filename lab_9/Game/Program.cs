namespace Game;

internal class Program
{
    static void Main(string[] args)
    {
            Gamer g1 = new Gamer("Niko");
            g1.session.MaxPointEvent += g1.MaxPointsHappened;

            for (int i = 1; i <= 6; i++)
                Console.WriteLine("It is {0} points for player {1}", g1.SessionGame(), g1.ToString());
    }
}
