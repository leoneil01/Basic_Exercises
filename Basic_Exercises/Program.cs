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
		    
		    Console.Write("Please enter the first integer: ");
		    string x = Console.ReadLine();
		    Console.Write("Please enter the second integer: ");
		    string y = Console.ReadLine();
		    
		    Console.WriteLine("-------------------------------");
		    
		    Console.WriteLine("Minimum Value: {0}", program1.Test(x, y));
		}
		
		public string Test(string str1, string str2) {
		    return Int32.Parse(str1) > Int32.Parse(str2) ? str2 : str1;
		}
    }
}
