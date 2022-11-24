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
        Console.Write("Input an integer: ");
        int i = Convert.ToInt32(Console.ReadLine());
        
        int[] numbers = {1, 2, 2, 3, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
        
        Console.WriteLine(numbers[0] == i || numbers[numbers.Length - 1] == i);
    }
}
