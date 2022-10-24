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
            int[] number = new int[3];
            int total;

            Console.Write("Input the first number to multiply: ");
            number[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            number[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            number[2] = Convert.ToInt32(Console.ReadLine());

            total = number[0] * number[1] * number[2];
            Console.WriteLine($"\n{number[0]} x {number[1]} x {number[2]} = {total}");
        }
    }
}
