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
		    string input = Console.ReadLine();
		    
		    Console.WriteLine("-------------------------------------------");
		    Console.WriteLine("Original String: {0}", input);
		    Console.WriteLine("Test for consecutive similar letter: {0}", program.Test(input));
		}
		
		public bool Test(string str) {
		    for(int i = 0; i < str.Length - 1; i++) {
		        if(str[i] == str[i + 1])
		            return true;
		    }
		    return false;
		}
    }
}
