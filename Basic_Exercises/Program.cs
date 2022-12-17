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
		    
		    int[] nums1 = { 1, 2, 3 };
		    int[] nums2 = { -2, 0, 3, 4 };
		    
		    Console.WriteLine("Array1: [{0}]", string.Join(", ", nums1));
		    Console.WriteLine("Sum of squares of elements of the said array: {0}", program.Test(nums1));
		    Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));
		    Console.WriteLine("Sum of squares of elements of the said array: {0}", program.Test(nums2));
		}
		
		public int Test(int[] nums) {
		    return nums.Sum(n => n * n);
		}
    }
}
