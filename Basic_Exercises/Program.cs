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
			
			Console.WriteLine("Get the ASCII value of a given character");
			Console.WriteLine("------------------------------------------");
			
			Console.Write("Please enter a character: ");
			char input = Convert.ToChar(Console.ReadLine());
			
			Console.WriteLine("ASCII value of {0} is: {1}", input, program.Test(input));
		}
		
		public int Test(char i) {
			return (int)i;
		}
    }
}
