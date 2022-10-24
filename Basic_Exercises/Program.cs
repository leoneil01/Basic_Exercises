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
            int age;

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou look older than {age}");
        }
    }
}
