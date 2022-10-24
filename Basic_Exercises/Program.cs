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
            int[] total = new int[11];
            int number;

            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            total[0] = number * 0;
            total[1] = number * 1;
            total[2] = number * 2;
            total[3] = number * 3;
            total[4] = number * 4;
            total[5] = number * 5;
            total[6] = number * 6;
            total[7] = number * 7;
            total[8] = number * 8;
            total[9] = number * 9;
            total[10] = number * 10;

            Console.WriteLine($"\n{number} * 0 = {total[0]}");
            Console.WriteLine($"{number} * 1 = {total[1]}");
            Console.WriteLine($"{number} * 2 = {total[2]}");
            Console.WriteLine($"{number} * 3 = {total[3]}");
            Console.WriteLine($"{number} * 4 = {total[4]}");
            Console.WriteLine($"{number} * 5 = {total[5]}");
            Console.WriteLine($"{number} * 6 = {total[6]}");
            Console.WriteLine($"{number} * 7 = {total[7]}");
            Console.WriteLine($"{number} * 8 = {total[8]}");
            Console.WriteLine($"{number} * 9 = {total[9]}");
            Console.WriteLine($"{number} * 10 = {total[10]}");
        }
    }
}
