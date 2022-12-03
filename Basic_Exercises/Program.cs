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
    	public static void Main(string[] args) {
		    Program program1 = new Program();
		    
		    Console.WriteLine("Replacing 'P' with '9', 'T' with '0', 'H' with '6' and 'A' with '8'\n");
		    
		    Console.Write("Please enter a string: ");
		    string input = Console.ReadLine();
		    Console.WriteLine("Replaced Value: {0}", program1.Test(input));
		}
		
		public string Test(string str) {
		    return str.Replace("P", "9").Replace("T", "0").Replace("H", "6").Replace("A", "8").Replace("p", "9").Replace("t", "0").Replace("h", "6").Replace("a", "8");
		}
    }
}
