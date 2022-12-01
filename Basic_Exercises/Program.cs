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
    	public static void Main(string[] args) {
		    // Program rrp = new Program();
		    
		    // Console.WriteLine("Reverse the strings contained in each pair of matching parentheses in a given string");
		    // Console.WriteLine("\n--------------------------------------------------------------------------------------\n");
		    
		    // Console.WriteLine("String1: p(rq)st");
		    // Console.WriteLine("Reverse String1: {0}", rrp.ReverseRemoveParentheses("p(rq)st"));
		    // Console.WriteLine("String2: (p(rq)st)");
		    // Console.WriteLine("Reverse String2: {0}", rrp.ReverseRemoveParentheses("(p(rq)st)"));
		    // Console.WriteLine("String3: ab(cd(ef)gh)ij)");
		    // Console.WriteLine("Reverse String3: {0}", rrp.ReverseRemoveParentheses("ab(cd(ef)gh)ij"));
		}
    
		// public string ReverseRemoveParentheses(string str) {
		//     int lid = str.LastIndexOf('(');
		//     if(lid == -1) {
		//         return str;
		//     } else {
		//         int rid = str.IndexOf(')', lid);
		        
		//         return ReverseRemoveParentheses(
		//             str.Substring(0, lid)
		//             + new string(str.Substring(lid + 1, rid - lid -1).Reverse().ToArray())
		//             + str.Substring(rid + 1)
		//         );
		//     }
		// }
    }
}
