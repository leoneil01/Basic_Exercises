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
		    
		    Console.Write("Please enter a string: ");
		    string input1 = Console.ReadLine();
		    Console.Write("Please enter upper case single character to be counted: ");
		    char input2 = Convert.ToChar(Console.ReadLine());
		    Console.Write("Please enter lower case single character to be counted: ");
		    char input3 = Convert.ToChar(Console.ReadLine());
		    
		    Console.WriteLine("--------------------------------------------------------");
		    Console.WriteLine("The counted character of {0} and {1} in a given string is {2}", input2, input3, program.Test(input1, input2, input3));
		}
		
		public int Test(string str, char upperCase, char lowerCase) {
		    return str.Split(upperCase, lowerCase).Length - 1;
		}
    }
}
