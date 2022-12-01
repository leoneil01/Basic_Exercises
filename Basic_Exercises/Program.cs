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
		    Program program1 = new Program();
		    
		    Console.Write("Please enter a file path (i.e c:/csharp/ex/test.cpp): ");
		    string filePath = Console.ReadLine();
		    
		    Console.WriteLine("File Name (w/ extension): {0}", program1.Test(filePath));
		}
		
		public string Test(string filePath) {
		    return filePath.Split('/').Last();
		}
    }
}
