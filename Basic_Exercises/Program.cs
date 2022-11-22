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
		    Console.Write("Input a string: ");
		    string str = Console.ReadLine();
		    
		    // takes the first three indexes and if it's three w (www), will print false
		    Console.WriteLine(str.Length > 2 ? (str.Substring(0, 1).Equals("w") && str.Substring(1, 2).Equals("ww") ? false : true) : true); // ?bug
		    
		    // if(str.Length > 2) {
		    //     Console.WriteLine(str.Substring(0, 1).Equals("w") && str.Substring(1, 2).Equals("ww") ? false : true);
		    // } else {
		    //     Console.WriteLine(true);
		    // }
        }
    }
}
