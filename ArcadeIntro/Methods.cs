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
                    break;
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

        public static void AdjacentElementsProduct()
        {
            //Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
            int[] arr1 = { 3, 6, -2, -5, 7, 3 };
            int max = arr1[0] * arr1[1];
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if ((arr1[i] * arr1[i + 1]) > max)
                {
                    max = arr1[i] * arr1[i + 1];
                }
            }
            Console.WriteLine($"Given the following integer array, the largest product of two adjacent elements is {max}.\n" +
                "{ 3, 6, -2, -5, 7, 3 }\n");
        }

        public static void ShapeArea()
        {
            //Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.

            //A 1 - interesting polygon is just a square with a side of length 1. An n - interesting polygon is obtained by taking the n - 1 - interesting polygon and appending 1 - interesting polygons to its rim, side by side.
            //for n = 1, the area should be 1; for n = 2, the area should be 5; for n = 3, the calculated area should be 13, etc.
            Console.WriteLine("An n-interesting polygon is obtained by taking the n-interesting polygon and appending 1-interesting polygons to its rim, side-by-side.\n");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            int area = (n * n) + ((n - 1) * (n - 1));
            Console.WriteLine($"An {n:n0}-interesting polygon has an area of {area:n0}.\n");
        }

        public static void MakeArrayConsecutive2()
        {
            //Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non - negative integer size.Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1.He may need some additional statues to be able to accomplish that.Help him figure out the minimum number of additional statues needed.
            int[] statues = { 6, 2, 3, 8 };
            int needed = statues.Max() - statues.Min() - statues.Length + 1;
            Console.WriteLine($"After arranging the array of statues with sizes [ 6, 2, 3, 8 ] from smallest to largest, you would need {needed} more statues to have one statue of each height.");
        }
    }
}
