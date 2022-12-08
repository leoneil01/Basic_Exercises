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
			
			Console.WriteLine("Check whether a given word is plural or not");
			Console.WriteLine("------------------------------------------");
			
			Console.Write("Please enter a string: ");
			string input = Console.ReadLine();
			
			Console.WriteLine("Is '{0}' is plural? {1}", input, program.Test(input));
		}
		
		public bool Test(string str) {
			return str.EndsWith("s"); //* plural with 's' only, this doesn't include irregular plural like foot to feet
		}
    }
}
