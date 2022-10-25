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

            Console.WriteLine(AbsoluteValueDouble(number[0], number[1]));
        }

        public static int AbsoluteValueDouble(int x, int y)
        {
            return x > y ? (x - y) * 2 : (x - y) * (-1);
        }
    }
}
