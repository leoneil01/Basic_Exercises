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
        static void Main(string[] args)
        {
		    Console.Write("Test Date: ");
		    string str = Console.ReadLine();
		    
		    if(str.Substring(1, 2) == "HP" || str.Substring(1, 2) == "hp") {
		        Console.WriteLine(str.Remove(1, 2));   
		    } else {
		        Console.WriteLine(str);
		    }
        }
    }
}
