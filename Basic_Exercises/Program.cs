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
        int[] array = {1, 2, 8};
        Console.WriteLine("Array: {0}", string.Join(", ", array));
        
        int x = array[0];
        for(int i = 0; i < array.Length - 1; i++) {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = x;
        
        Console.WriteLine("Array after rotation: {0}", string.Join(", ", array));
    }
}
