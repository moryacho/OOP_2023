using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class SquareRoots
    {
        public static void Command()
        {
            Console.WriteLine("\nHi! Let's count roots of quadratic equation!");

            Console.WriteLine("input a");
            int a = GetIntNumber();

            Console.WriteLine("input b");
            int b = GetIntNumber();

            Console.WriteLine("input c");
            int c = GetIntNumber();

            double[] roots = CountRoots(a, b, c);

            if (b * b - 4 * a * c >= 0)
            {
                Console.WriteLine($"root 1 = {roots[0]}\n" +
                $"root 2 = {roots[1]}");
            }
            else
            {
                Console.WriteLine("no roots here((((");
            }
        }

        public static double[] CountRoots(int a,  int b, int c)
        {
            double[] roots = new double[2];
            double discriminant = Math.Sqrt(b * b - 4 * a * c);

            if (discriminant >= 0)
            {
                roots[0] = (-b + discriminant) / (2 * a);
                roots[1] = (-b - discriminant) / (2 * a);
            }

            return roots;
        }

        public static int GetIntNumber()
        {
            string? parStr;
            bool success;
            int parInt;

            while (true)
            {
                Console.Write($"input int number: ");
                parStr = Console.ReadLine();
                success = int.TryParse(parStr, out parInt);

                if (success)
                {
                    return parInt;
                }
            }
        }
    }
}
