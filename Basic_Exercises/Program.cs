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
		    
		    Console.WriteLine("Check if a given string contains only lowercase or uppercase characters");
		    Console.WriteLine("-------------------------------------------------------------------------");
		    
		    Console.Write("Please enter a string: ");
		    string input = Console.ReadLine();
		    
		    Console.WriteLine(program.Test(input));
		}
		
		public bool Test(string str) {
		    return str == str.ToUpper() || str == str.ToLower();
		}
    }
}
