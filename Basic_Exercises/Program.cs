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
            int[] total = new int[5];
            int[] number = new int[2];

            Console.Write("Input the first number: ");
            number[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            number[1] = Convert.ToInt32(Console.ReadLine());

            total[0] = number[0] + number[1];
            total[1] = number[0] - number[1];
            total[2] = number[0] * number[1];
            total[3] = number[0] / number[1];
            total[4] = number[0] % number[1];

            Console.WriteLine($"\n{number[0]} + {number[1]} = {total[0]}");
            Console.WriteLine($"{number[0]} - {number[1]} = {total[1]}");
            Console.WriteLine($"{number[0]} x {number[1]} = {total[2]}");
            Console.WriteLine($"{number[0]} / {number[1]} = {total[3]}");
            Console.WriteLine($"{number[0]} mod {number[1]} = {total[4]}");
        }
    }
}
