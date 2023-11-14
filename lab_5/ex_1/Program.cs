namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };

            foreach (int x in myArray) Console.Write("{0} ", x);

            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    myArray[i] = 0;
                }

                Console.Write(myArray[i] + " ");
            }

            int[] myArray2;
            Console.Write("\ninput (int) array length: ");
            int n = int.Parse(Console.ReadLine());
            myArray2 = new int[n];

            for (int i = 0; i < myArray2.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                myArray2[i] = int.Parse(Console.ReadLine());
            }

            foreach (int x in myArray2) Console.Write("{0} ", x);

            Console.WriteLine();

            for (int i = 0; i < myArray2.Length; i++)
            {
                if (myArray2[i] % 2 == 0)
                {
                    myArray2[i] = 0;
                }

                Console.Write(myArray2[i] + " ");
            }
        }
    }
}