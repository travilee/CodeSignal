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
            //Write a function that returns the sum of two numbers.
            Console.Write("Enter the first integer: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}\n");
        }

        public static void CenturyFromYear()
        {
            //Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second -from the year 101 up to and including the year 200, etc.
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

        public static void CheckPalindrome()
        {
            //Given the string, check if it is a palindrome.
            Console.Write("Enter a word or phrase to check and see if it is a palindrome: ");
            string input = Console.ReadLine();
            string noSpaces = input.Replace(" ", "");
            bool isPalindrome = true;
            for (int i = 0; i <= noSpaces.Length / 2; i++)
            {
                if (noSpaces[i] != noSpaces[noSpaces.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome!\n");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome!\n");
            }
        }
    }
}
