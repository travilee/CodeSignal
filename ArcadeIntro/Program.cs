using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}");
        }
    }
}
