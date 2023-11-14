namespace ex_2_p_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n1 - cycle thing\n2 - sin thing\n3 - evklid thing\nother - quit program\nur choice: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CycleThing();
               Main(args);
            }
            else if (choice == "2")
            {
                SinThing();
                Main(args);
            }
            else if (choice == "3")
            {
                EvklidThing();
                Main(args);
            }
        }

        static void CycleThing()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);

            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
        }

        static void SinThing()
        {
            Console.Write("input x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("input x2: ");
            double x2 = double.Parse(Console.ReadLine());
            double x = x1;
            double y = Math.Sin(x);
            do
            {
                y = Math.Sin(x);
                y = Math.Round(y, 2);
                x = Math.Round(x, 2);
                Console.WriteLine($"x = {x} \t y = {y}");
                x += 0.01;
            }
            while (x <= x2);
        }

        static void EvklidThing()
        {
            Console.Write("Input int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input int b: ");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine($"LCM: {a}");
        }
    }
}