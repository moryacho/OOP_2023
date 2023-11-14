using System.Security.Cryptography.X509Certificates;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = InputMatrix();

            Console.WriteLine();
            int matrixSum = GetSum(matrix);
            Console.WriteLine($"sum: {matrixSum}");

            double average = Average(matrix);
            Console.WriteLine($"average: {average}");

            int[] sPlusMinus = SumPlusMinus(matrix);
            Console.WriteLine($"sum plus: {sPlusMinus[0]}\n" +
                $"sum minus: {sPlusMinus[1]}");

            int[] sChetNechet = SumChetNechet(matrix);
            Console.WriteLine($"sum chet counts: {sChetNechet[0]}\n" +
                $"sum nechet counts: {sChetNechet[1]}");

            int[] maxThing = GetMax(matrix);
            Console.WriteLine($"max number: {maxThing[0]}\n" +
                $"position: [{maxThing[1]}, {maxThing[2]}]\n");

            int[] minThing = GetMin(matrix);
            Console.WriteLine($"min number: {minThing[0]}\n" +
                $"position: [{minThing[1]}, {minThing[2]}]");


            Console.ReadLine();

        }

        public static int[,] InputMatrix()
        {
            Console.Write("input size of matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"array[{i};{j}]: ");// строка столбец
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
            }

            return matrix;
        }

        public static int GetSum(int[,] matrix)
        {
            int s = 0;

            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    s += matrix[i, j];
                }
            }

            return s;
        }

        public static double Average(int[,] matrix)
        {
            int sum = GetSum(matrix);
            int n = matrix.GetLength(0);
            double average = sum / n;

            return average;
        }

        public static int[] SumPlusMinus(int[,] matrix)
        {
            int sPlus = 0;
            int sMinus = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sMinus += matrix[i, j];
                    }
                    else
                    {
                        sPlus += matrix[i, j];
                    }
                }
            }

            return new int[] { sPlus, sMinus };
        }

        public static int[] SumChetNechet(int[,] matrix)
        {
            int sChet = 0;
            int sNechet = 0;
            int k = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    k += 1;
                    if (k % 2 == 0)
                    {
                        sChet += matrix[i, j];
                    }
                    else
                    {
                        sNechet += matrix[i, j];
                    }
                }
            }

            return new int[] {sChet, sNechet };
        }

        public static int[] GetMax(int[,] matrix)
        {
            int maxNumber = matrix[0, 0];
            int[] maxPosition = new int[2] {0, 0};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] > maxNumber)
                    {
                        maxNumber = matrix[i, j];
                        maxPosition = new int[] {i, j};
                    }
                }
            }

            return new int[] {maxNumber, maxPosition[0], maxPosition[1]};
        }

        public static int[] GetMin(int[,] matrix)
        {
            int minNumber = matrix[0, 0];
            int[] minPosition = new int[2] { 0, 0 };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] < minNumber)
                    {
                        minNumber = matrix[i, j];
                        minPosition = new int[] { i, j };
                    }
                }
            }

            return new int[] { minNumber, minPosition[0], minPosition[1] };
        }

    }
}