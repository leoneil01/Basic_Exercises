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
			
			Console.WriteLine("Take a positive number and return the nth odd number");
			Console.WriteLine("-----------------------------------------------------");
			
			Console.WriteLine("1st odd number: {0}", program.Test(1));
			Console.WriteLine("2nd odd number: {0}", program.Test(2));
			Console.WriteLine("3rd odd number: {0}", program.Test(3));
			Console.WriteLine("4th odd number: {0}", program.Test(4));
			Console.WriteLine("100th odd number: {0}", program.Test(100));
		}
		
		public int Test(int i) {
			return i * 2 - 1;
		}
    }
}
