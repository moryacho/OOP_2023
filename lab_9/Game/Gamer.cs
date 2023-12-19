using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game;

internal class Gamer
{
    string Name;
    public Dice session;

    public Gamer(string Name)
    {
        this.Name = Name;
        this.session = new Dice();
    }

    public override string ToString()
    {
        return Name;
    }

    public int SessionGame()
    {
        return session.random();
    }

    public void MaxPointsHappened(int points)
    {
        Console.WriteLine($"Super! It is max points: {points}");
    }
}
