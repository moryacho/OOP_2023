using System;

public struct Distance
{
    public int feet;
    public int inches;

    public Distance(int ft, int inch)
    {
        feet = ft;
        inches = inch;
    }

    public override string ToString()
    {
        return feet + "' " + inches + "\"";
    }
}

class Program
{
    static void Main()
    {
        Distance distance1, distance2, distance3;

        Console.Write("Enter the value for the first distance (feet): ");
        int feet1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the first distance (inches): ");
        int inches1 = int.Parse(Console.ReadLine());
        distance1 = new Distance(feet1, inches1);

        Console.Write("Enter the value for the second distance (feet): ");
        int feet2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the second distance (inches): ");
        int inches2 = int.Parse(Console.ReadLine());
        distance2 = new Distance(feet2, inches2);

        distance3.feet = distance1.feet + distance2.feet + (distance1.inches + distance2.inches) / 12;
        distance3.inches = (distance1.inches + distance2.inches) % 12;

        Console.WriteLine("The sum of the distances is: " + distance3.ToString());
    }
}
