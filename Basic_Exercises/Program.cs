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
        int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        int[] array2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
        Console.WriteLine("Array1: [{0}]", string.Join(", ", array1));
        Console.WriteLine("Array2: [{0}]", string.Join(", ", array2));
        
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("Check if the first and last element of the two arrays (length is more than 1) is equal.");
        
        Console.WriteLine((array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1]) && (array1.Length > 1 && array2.Length > 1));
    }
}
