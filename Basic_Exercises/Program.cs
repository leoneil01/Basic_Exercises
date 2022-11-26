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
        int[] array = {1, 2, 5, 7, 8};
        Console.WriteLine("Array: [{0}]", string.Join(", ", array));
        
        Console.WriteLine("\n--------------------------------------------------\n");
        
        int highestVal = array[0] < array[array.Length - 1] ? array[array.Length - 1] : array[0];
        Console.WriteLine("Highest value between first and last values of the said array: {0}", highestVal);
    }
}
