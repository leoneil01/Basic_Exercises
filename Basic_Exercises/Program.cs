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
		    Console.Write("Input a string: ");
		    string str = Console.ReadLine();
		    
		    Console.WriteLine(str.Length < 4 ? str.ToUpper() : str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
        }
    }
}
