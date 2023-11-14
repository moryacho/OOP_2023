using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    public static class Operation
    {
        public static void Command()
        {
            Console.WriteLine("\nHi! Let's count triangle's square!");
            string trType = GetTriangleType();
            Console.WriteLine("Cool! Let's get sides of triangle!");
            int[] sides = GetTriangleSides(trType);
            Console.WriteLine("Great! Count square)");
            double square = GetSquare(sides);
            Console.WriteLine($"Square of this triangle is {square}");
            Console.ReadLine();
        }

        public static string GetTriangleType()
        {
            while (true)
            {
                Console.Write("choose triangle type:\n" +
                "1 - equilateral\n" +
                "2 - versatile\n" +
                "your choice: ");
                string ans = Console.ReadLine();

                if (ans == "1" || ans == "2")
                {
                    return ans;
                }
            }
        }

        public static double GetSquare(int[] sides)
        {
            double halfP = sides.Sum() / 2;
            double ans = Math.Sqrt(halfP * (halfP - sides[0]) * (halfP - sides[1]) * (halfP - sides[2]) );
            return ans;
        }

        public static int[] GetTriangleSides(string trType)
        {
            int[] sides = new int[3];
            if (trType == "1")
            {
                Console.WriteLine("input one side");
                int side = GetNaturalNumber();
                sides = new int[3] { side, side, side };

                return sides;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("side 1");
                    sides[0] = GetNaturalNumber();

                    Console.WriteLine("side 2");
                    sides[1] = GetNaturalNumber();

                    Console.WriteLine("side 3");
                    sides[2] = GetNaturalNumber();

                    if (CheckTriangle(sides))
                    {
                        return sides;
                    }
                    else
                    {
                        Console.WriteLine("this triangle does not not exist!");
                    }
                }
            }
        }

        public static bool CheckTriangle(int[] triangleSides)
        {
            if (2 * triangleSides.Max() - triangleSides.Sum() < 0)
            {
                return true;
            }

            return false;
        }

        public static int GetNaturalNumber()
        {
            string? parStr;
            bool success;
            int parInt;

            while (true)
            {
                Console.Write($"input natural number: ");
                parStr = Console.ReadLine();
                success = int.TryParse(parStr, out parInt);

                if (success && parInt > 0)
                {
                    return parInt;
                }
            }
        }
    }
}
