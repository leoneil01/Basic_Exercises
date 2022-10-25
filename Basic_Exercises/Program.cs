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
            int digit;

            Console.Write("Enter a digit: ");
            digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{digit} {digit} {digit} {digit}");
            Console.WriteLine($"{digit}{digit}{digit}{digit}");
            Console.WriteLine($"{digit} {digit} {digit} {digit}");
            Console.WriteLine($"{digit}{digit}{digit}{digit}");
        }
    }
}
