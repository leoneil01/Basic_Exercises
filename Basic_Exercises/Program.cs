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
        int[] array1 = {1, 2, 5};
        int[] array2 = {0, 3, 8};
        int[] array3 = {-1, 0, 2};
        Console.WriteLine("Array1: [{0}]", string.Join(", ", array1));
        Console.WriteLine("Array2: [{0}]", string.Join(", ", array2));
        Console.WriteLine("Array3: [{0}]", string.Join(", ", array3));
        
        Console.WriteLine("\n-------------------------\n");
        
        int[] newArray = {array1[1], array2[1], array3[1]};
        Console.WriteLine("New array: [{0}]", string.Join(", ", newArray));
    }
}
