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
		    Program program = new Program();
		    
		    Console.WriteLine("Remove the first and last elements from a given string");
		    Console.WriteLine("-------------------------------------------------------");
		    
		    Console.Write("Please enter a string: ");
		    string input = Console.ReadLine();
		    
		    Console.WriteLine("After removing first and last elements: {0}", program.Test(input));
		}
		
		public string Test(string str) {
		    return str.Length > 1 ? str.Substring(1, str.Length - 2) : str;
		}
    }
}
