using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
		    Console.Write("Input the first integer: ");
		    int int1 = Convert.ToInt32(Console.ReadLine());
		    Console.Write("Input the second integer: ");
		    int int2 = Convert.ToInt32(Console.ReadLine());
		    Console.Write("Input the third integer: ");
		    int int3 = Convert.ToInt32(Console.ReadLine());
		    
		    Console.WriteLine("Largest integer: {0}", Math.Max(int1, Math.Max(int2, int3)));
		    Console.WriteLine("Lowest integer: {0}", Math.Min(int1, Math.Min(int2, int3)));
        }
    }
}
