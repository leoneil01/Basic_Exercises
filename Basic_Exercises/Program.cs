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
            string str, toLower;

            Console.Write("Enter a text: ");
            str = Console.ReadLine();
            toLower = str.ToLower();

            Console.WriteLine($"\n{toLower}");
        }
    }
}
