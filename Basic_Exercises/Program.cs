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
        int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1
        };
        Console.WriteLine("Array: {0}", string.Join(", ", array));
        
        int total = 0;
        for(int i = 0; i < array.Length; i++) {
            total += array[i];
        }
        Console.WriteLine("Sum: {0}", total);
    }
}
