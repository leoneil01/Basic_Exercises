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
		    Console.Write("Input a first number(<100): ");
		    int firstNumber = Convert.ToInt32(Console.ReadLine());
		    Console.Write("Input a second number(>200): ");
		    int secondNumber = Convert.ToInt32(Console.ReadLine()); 
		    
		    // if(firstNumber < 100 && secondNumber > 200) {
		    // 	Console.WriteLine(true);
		    // } else {
		    //     Console.WriteLine(false);
		    // }
		    
		    Console.WriteLine(firstNumber < 100 && secondNumber > 200);
        }
    }
}
