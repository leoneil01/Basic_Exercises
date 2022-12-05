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
		    
		    int[] num1 = {1, 2, 3, 5, 4, 2, 3, 4};
		    Console.WriteLine("Array1: [{0}]", string.Join(", ", num1));
		    Console.WriteLine("Check whether the average value of the said array is a whole number or not: " + program.Test(num1));
		    
		    Console.WriteLine("---------------------------------------------------------------------------------");
		    
		    int[] num2 = {2, 4, 2, 6, 4, 8};
		    Console.WriteLine("Array2: [{0}]", string.Join(", ", num2));
		    Console.WriteLine("Check whether the average value of the said array is a whole number or not: " + program.Test(num2));
		}
		
		public bool Test(int[] array) {
		    return array.Average() % 1 == 0;
		}
    }
}
