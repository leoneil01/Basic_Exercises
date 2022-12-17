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
<<<<<<< HEAD
		    Program program = new Program();
		    
		    int[] nums1 = { 1, 2, 3 };
		    int[] nums2 = { -2, 0, 3, 4 };
		    
		    Console.WriteLine("Array1: [{0}]", string.Join(", ", nums1));
		    Console.WriteLine("Sum of squares of elements of the said array: {0}", program.Test(nums1));
		    Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));
		    Console.WriteLine("Sum of squares of elements of the said array: {0}", program.Test(nums2));
		}
		
		public int Test(int[] nums) {
		    return nums.Sum(n => n * n);
=======
			Program program = new Program();
			
			Console.WriteLine("Check whether a given word is plural or not");
			Console.WriteLine("------------------------------------------");
			
			Console.Write("Please enter a string: ");
			string input = Console.ReadLine();
			
			Console.WriteLine("Is '{0}' is plural? {1}", input, program.Test(input));
		}
		
		public bool Test(string str) {
			return str.EndsWith("s"); //* plural with 's' only, this doesn't include irregular plural like foot to feet
>>>>>>> 2a0e8ace6b1f8ca75234f0cec9c493a9c50ed76e
		}
    }
}
