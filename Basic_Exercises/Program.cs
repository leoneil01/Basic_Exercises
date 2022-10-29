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
            // must add text.txt file in your desktop and change the 'admin' to your local Users name
            FileInfo fileInfo = new FileInfo("C:/Users/admin/Desktop/text.txt"); 
            Console.WriteLine($"File Size: {fileInfo.Length.ToString()}");
        }
    }
}
