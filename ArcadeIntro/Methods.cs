using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeIntro
{
    public class Methods
    {
        public static void AddNumbers()
        {
            Console.Write("Enter the first integer: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}\n");
        }

        public static void CenturyFromYear()
        {
            Console.Write("Enter a year, 1 or higher, to see what century it is in: ");
            int year = int.Parse(Console.ReadLine());
            int century = 0;
            if (year % 100 == 0)
            {
                century = year / 100;
            }
            else
            {
                century = (year + 100) / 100;
            }
            Console.WriteLine($"The year {year} is in century {century}.\n");
        }
    }
}
