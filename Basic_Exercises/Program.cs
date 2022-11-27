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
		    int[] array = {2, 4, 7, 8, 6};
		    Console.WriteLine("Original Array: [{0}]", string.Join(", ", array));
		    
		    Console.WriteLine("\n--------------------------------------------\n");
		    
		    Console.WriteLine("Checks if an array contains an odd number?");
		    Console.WriteLine(evenOdd(array));
        }
        
		public static bool evenOdd(int[] array) {
		    foreach(int i in array) {
		        if(i % 2 != 0)
		            return true;
		    }
		    return false;
		}
    }
}
