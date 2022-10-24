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
            int num1, num2;

            Console.Write("Input the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nFirst Number: {num2}");
            Console.WriteLine($"Second Number: {num1}");
        }
    }
}
