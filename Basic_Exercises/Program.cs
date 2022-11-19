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
		    Console.Write("Input integer: ");
		    int i = Convert.ToInt32(Console.ReadLine());
		    
		    if(i > 0) {
		        Console.WriteLine(i % 3 == 0 || i % 7 == 0);
		    }
        }
    }
}
