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
            int[] total = new int[4];

            total[0] = -1 + 4 * 6;
            total[1] = (35 + 5) % 7;
            total[2] = 14 + (-4) * 6 / 11;
            total[3] = 2 + 15 / 6 * 1 -7 % 2;

            Console.WriteLine(total[0]);
            Console.WriteLine(total[1]);
            Console.WriteLine(total[2]);
            Console.WriteLine(total[3]);
        }
    }
}
