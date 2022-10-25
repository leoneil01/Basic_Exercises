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
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            if (text.Length >= 1)
            {
                var a = text.Substring(0, 1);
                Console.WriteLine(a + text + a);
            }
        }
    }
}
