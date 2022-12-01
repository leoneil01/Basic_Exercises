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
		    Program testProg = new Program();
		    
		    Console.WriteLine("Check if a given number present in an array of numbers");
		    Console.WriteLine("\n--------------------------------------------------------\n");
		    
		    int[] array = {1, 3, 5, 7, 9};
		    Console.Write("Please enter an integer: ");
		    int input = Convert.ToInt32(Console.ReadLine());
		    
		    Console.WriteLine(testProg.Test(array, input));
		    Console.WriteLine("Array: [{0}]", string.Join(", ", array));
		}
		
		public bool Test(int[] array, int n) {
		    return array.Contains(n);
		}
    }
}
