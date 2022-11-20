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
		    Console.Write("Input a first number: ");
		    int firstNumber = Convert.ToInt32(Console.ReadLine());
		    Console.Write("Input a second number: ");
		    int secondNumber = Convert.ToInt32(Console.ReadLine()); 
		    
		    Console.WriteLine((firstNumber > -10 && firstNumber < 10) || (secondNumber > -10 && secondNumber < 10));
        }
    }
}
