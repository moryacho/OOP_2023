namespace ex_1_p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;
            while (isActive)
            {
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("OP = ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("B = ");
                double b = double.Parse(Console.ReadLine());
                bool ok = true;
                double res = 0;

                switch (op)
                {
                    case '+': res = a + b; break;
                    case '-': res = a - b; break;
                    case '*': res = a * b; break;
                    case '/':
                    case ':':
                        res = a / b; break;
                    default: ok = false; break;
                }

                if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
                else Console.WriteLine("Операция не определена");
                bool isCorrectInput = false;

                while (!isCorrectInput)
                {
                    Console.Write("Would you like to play again (y/n): ");
                    string ans = Console.ReadLine();
                    if (ans == "y" | ans == "n")
                    {
                        isCorrectInput = true;
                    }

                    if (ans == "n")
                    {
                        isActive = false;
                    }
                }
            }
        }
    }
}