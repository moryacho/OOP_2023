namespace ex_2_p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input k (sum from 1 to k): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("input m (sim from m to 100): ");
            int m = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                result += i;
            }
            Console.WriteLine($"result sum: {result}");
        }
    }
}