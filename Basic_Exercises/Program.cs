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
		    
		    Console.WriteLine("Check the length of a given string is odd or even\n");
		    Console.Write("Please enter a string: ");
		    string input = Console.ReadLine();
		    
		    Console.WriteLine("------------------------------------------------------------------------");
		    
		    Console.WriteLine("String: {0}", input);
		    Console.WriteLine("String Length: {0}", program.Test(input));
		}
		
		public string Test(string str) {
		    if(str.Length % 2 == 1)
		        return "Odd";
		    return "Even";
		}
    }
}
