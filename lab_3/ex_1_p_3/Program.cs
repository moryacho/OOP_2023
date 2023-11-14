//Дано натуральное число. Требуется определить, является ли год с
//данным номером високосным. Если год является високосным, то выведите
//YES, иначе выведите NO.
//Указание: год является високосным, если его номер кратен 4, но не
//кратен 100, а также, если он кратен 400.

namespace ex_1_p_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            while (true)
            {
                Console.Write("Input year: ");
                string strYear = Console.ReadLine();
                if (CheckNaturalNumber(strYear))
                {
                    year = int.Parse(strYear);
                    break;
                }
            }

            if (CheckLeapYear(year))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool CheckNaturalNumber(string year)
        {
            bool checkToInt = int.TryParse(year, out _);
            if (checkToInt)
            {
                if (int.Parse(year) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckLeapYear(int year)
        {
            if ( (year % 400 == 0) | (year % 4 == 0) & (year % 100 != 0) )
            {
                return true;
            }
            return false;
        }
    }
}