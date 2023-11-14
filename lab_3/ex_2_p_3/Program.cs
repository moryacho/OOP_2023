//В этом задании разработайте программу, имитирующую стрельбу по
//мишени.
//Реализуйте следующую функциональность:
//· Пользователь вводит данные о выстреле в виде пары чисел –
//координат x и y несколько раз.
//· Повтор ввода следует организовать в цикле. После «стрельбы»
//пользователю выводится информация о сумме очков.
//Вариант мишени определяется номером обучающегося по списку:
//нечетный – вариант 1, четный – вариант 2.

//Дополнительные указания:
//-реализовать центр мишени случайным значением, тогда стрелок не
//будет знать местонахождение мишени (стрельба вслепую);
//-реализовать случайную помеху при выстреле, тогда стрелок будет
//использовать трудности при стрельбе.


using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace ex_2_p_3
{
    internal class Program
    {
        const int MIN_X_Y_0 = -3;
        const int MAX_X_Y_0 = 3;
        const int R_FOR_10 = 1;
        const int R_FOR_5 = 2;
        const int R_FOR_1 = 3;
        const int OPTION_FOR_1_POINT = 2;
        const string X_OPTION = "x";
        const string Y_OPTION = "y";
        const string OPTION = "option";
        const string OPTION_1 = "1";
        const string OPTION_2 = "2";
        const int COUNT_OF_ATTEMPTS = 5;

        static int finalPlayerPoint = 0;

        static void Main(string[] args)
        {
            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine($"Hi, the best shooter in the world!\n" +
                $"You have {COUNT_OF_ATTEMPTS} attempts to hit the target!\n" +
                $"Min x and y: {MIN_X_Y_0}\n" +
                $"Max x and y: {MAX_X_Y_0}\n" +
                $"The gun is a little old, so you have a little hindrance when shooting (-0.5, +0, +0.5)\n" +
                $"After all of them u see points and can finish game or play again!");
                int option = InputCheck(OPTION);
                int[] x0_y0 = GetCenter();
                //Console.WriteLine($"Center: {x0_y0[0]} {x0_y0[1]}");
                int[] points = new int[COUNT_OF_ATTEMPTS];
                int[] x_y = new int[2];

                for (int attempt = 0; attempt < COUNT_OF_ATTEMPTS; attempt++)
                {
                    Console.WriteLine($"Attempt {attempt + 1}/{COUNT_OF_ATTEMPTS}");
                    x_y = MakeShot();
                    points[attempt] = GetPoint(option, x_y, x0_y0);
                }

                Console.WriteLine("You are out of attempts(( Here are your points:");

                for (int i = 0;  i < COUNT_OF_ATTEMPTS; i++)
                {
                    Console.WriteLine($"Attempt {i + 1}: {points[i]} points");
                }

                int sumPoints = points.Sum();
                finalPlayerPoint += sumPoints;
                Console.WriteLine($"sum of your points: {sumPoints}\n" +
                    $"Now you have {finalPlayerPoint} points\n");

                bool isCorrectAnswer = false;

                while ( !isCorrectAnswer )
                {
                    Console.Write("Would you like to continue game (y/n): ");
                    string ans = Console.ReadLine();

                    if (ans == "y" | ans == "n")
                    {
                        isCorrectAnswer = true;

                        if (ans == "n")
                        {
                            isActive = false;
                        }
                    }
                }
            }
        }

        static int InputCheck(string parameter)
        {
            if (parameter == X_OPTION | parameter == Y_OPTION)
            {
                Random rnd = new Random();
                int parInt;
                string? parStr;
                bool success;

                while (true)
                {
                    Console.Write($"input {parameter}: ");
                    parStr = Console.ReadLine();
                    success = int.TryParse(parStr, out parInt);

                    if (success && parInt >= MIN_X_Y_0 && parInt <= MAX_X_Y_0)
                    {
                        return parInt + rnd.Next(-1, 1) / 2;
                    }
                }
            }

            if (parameter == OPTION)
            {
                string? parStr;

                while (true)
                {
                    Console.Write($"input {parameter} (1 or 2): ");
                    parStr = Console.ReadLine();

                    if (parStr == OPTION_1 | parStr == OPTION_2)
                    {
                        return int.Parse(parStr);
                    }
                }
            }

            return MIN_X_Y_0 - 1;
        }

        static int[] MakeShot()
        {
            int x = InputCheck(X_OPTION);
            int y = InputCheck(Y_OPTION);
            int[] x_y = new int[2] { x, y };

            return x_y;
        }

        static int GetPoint(int option, int[] x_y, int[] x0_y0)
        {
            double rCurr = Math.Sqrt(Math.Pow(x_y[0] - x0_y0[0], 2) + Math.Pow(x_y[1] - x0_y0[1], 2));

            if (rCurr < R_FOR_10)
            {
                return 10;
            }
            else if (rCurr < R_FOR_5)
            {
                return 5;
            }

            if (option == OPTION_FOR_1_POINT && rCurr < R_FOR_1)
            {
                return 1;
            }

            return 0;
        }

        static int[] GetCenter()
        {
            Random rnd = new Random();
            int x0 = rnd.Next(MIN_X_Y_0, MAX_X_Y_0);
            int y0 = rnd.Next(MIN_X_Y_0, MAX_X_Y_0);
            int[] x_y = new int[2] {x0, y0};

            return x_y;
        }
    }
}