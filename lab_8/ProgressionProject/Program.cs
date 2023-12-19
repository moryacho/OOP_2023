namespace ProgressionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithProg = new ArithmeticProgression(1, 3);
            int element1 = arithProg.GetElement(3);
            Console.WriteLine("Элемент арифметической прогрессии: " + element1);

            GeometricProgression geomProg = new GeometricProgression(2, 2);
            int element2 = geomProg.GetElement(4);
            Console.WriteLine("Элемент геометрической прогрессии: " + element2);

            Console.ReadLine();
        }
    }
}
