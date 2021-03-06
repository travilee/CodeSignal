﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Console.Write("Choose an option from the menu below:\n\n" +
                "1) Add two integers\n" +
                "2) Get century from year\n" +
                "3) Check for palindrome\n" +
                "4) Find largest product from array of integers\n" +
                "5) Find area of 1-interesting polygon\n" +
                "6) Arrange statues by height" +
                "X) Exit\n" + 
                "\nYour selection: ");
                string selection = Console.ReadLine();
                Console.Clear();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Add two integers");
                        Methods.AddNumbers();
                        break;
                    case "2":
                        Console.WriteLine("Get century from year");
                        Methods.CenturyFromYear();
                        break;
                    case "3":
                        Console.WriteLine("Check for palindrome");
                        Methods.CheckPalindrome();
                        break;
                    case "4":
                        Console.WriteLine("Find largest product from array of integers");
                        Methods.AdjacentElementsProduct();
                        break;
                    case "5":
                        Console.WriteLine("Find area of 1-interesting polygon");
                        Methods.ShapeArea();
                        break;
                    case "6":
                        Console.WriteLine("Arrange statues by height\n");
                        Methods.MakeArrayConsecutive2();
                        break;
                    case "x":
                    case "X":
                        Console.WriteLine("Thanks for visiting!\n");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input not recognized. Please try again.");
                        break;
                }
            } while (!exit);

        }
    }
}
