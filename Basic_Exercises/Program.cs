using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{number}{number}{number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number} {number}");
            Console.WriteLine($"{number}{number}{number}");
        }
    }
}
