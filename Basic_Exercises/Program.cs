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

            Console.Write("Input first integer: ");
            number[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCheck if one is negative and one is positive:");
            Console.WriteLine((number[0] < 0 && number[1] > 0) || (number[0] > 0 && number[1] < 0));
        }
    }
}
