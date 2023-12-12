namespace MyTriangle;

internal class Program
{
    static void Main(string[] args)
    {
        Triangle t1 = new Triangle();
        t1.Show();
        Console.WriteLine();

        Triangle t2 = new Triangle(4, 5, 6);
        t2.Show();
        Console.WriteLine($"is exist: {t2.IsExist()}\n" +
            $"perimeter: {t2.GetPerimeter()}\n" +
            $"square: {t2.GetSquare()}");
        Console.WriteLine();

        Triangle t3 = new Triangle(1, 2, 3);
        t3.Show();
        Console.WriteLine($"is exist: {t3.IsExist()}\n" +
            $"perimeter: {t3.GetPerimeter()}\n" +
            $"square: {t3.GetSquare()}");

        Console.ReadLine();
    }
}
