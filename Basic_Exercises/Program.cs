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
            int num1, sum;

            Console.Write("Input a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            sum = 0;
            while (num1 != 0)
            {
                sum += num1 % 10;
                num1 /= 10;
            }

            Console.WriteLine($"\nSum of the digits of the said integer: {sum}");
        }
    }
}
