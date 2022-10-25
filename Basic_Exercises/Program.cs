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
            int num1;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 20 && num1 <= 100 || num1 == 200)
            {
                Console.WriteLine("False");
            }
        }
    }
}
