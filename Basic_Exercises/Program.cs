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
            double[] number = new double[4];
            double avg;

            Console.Write("Enter the first number: ");
            number[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            number[3] = Convert.ToDouble(Console.ReadLine());

            avg = (number[0] + number[1] + number[2] + number[3]) / 4;
            Console.WriteLine($"\nThe average of {number[0]}, {number[1]}, {number[2]}, {number[3]} is {avg}");
        }
    }
}
