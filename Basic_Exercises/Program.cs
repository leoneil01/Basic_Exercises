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
		    
		    string val1 = "50";
		    Console.WriteLine("Original value and type: {0}, {1}", val1, val1.GetType());
		    int result1 = program.StrToInt(val1);
		    Console.WriteLine("----Comvert string to integer----");
		    Console.WriteLine("Return value and type: {0}, {1}\n", result1, result1.GetType());
		    
		    int val2 = 122;
		    Console.WriteLine("Original value and type: {0}, {1}", val2, val2.GetType());
		    string result2 = program.IntToStr(val2);
		    Console.WriteLine("----Comvert string to integer----");
		    Console.WriteLine("Return value and type: {0}, {1}", result2, result2.GetType());
		}
		
		public int StrToInt(string str) {
		    return int.Parse(str);
		}
		public string IntToStr(int i) {
		    return i.ToString();
		}
    }
}
