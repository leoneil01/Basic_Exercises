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
            int x, y, z;
            int[] total = new int[2];

            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            total[0] = (x + y) * z;
            total[1] = (x * y) + (y * z);
            Console.WriteLine($"\nResult of specified numbers {x}, {y} and {z}, (x + y).z is {total[0]} and x.y + y.z is {total[1]}");
        }
    }
}
