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
		    Console.Write("Test Data: ");
		    string str = Console.ReadLine();
		    
		    Console.WriteLine(str.Substring(0, 1).Equals("P") && str.Substring(1, 1).Equals("H") ? str.Substring(0, 2) : str);
        }
    }
}
