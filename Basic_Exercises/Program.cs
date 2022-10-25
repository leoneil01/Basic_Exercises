using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[2];

            Console.Write("Input the first number: ");
            number[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            number[1] = Convert.ToInt32(Console.ReadLine());

            if (number[0] == 20 || number[1] == 20 || (number[0] + number[1] == 20))
            {
                Console.WriteLine($"\n{number[0]} + {number[1]} = {number[0] + number[1]}");
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine($"\n{number[0]} + {number[1]} = {number[0] + number[1]}");
                Console.WriteLine("False");
            }
        }
    }
}
