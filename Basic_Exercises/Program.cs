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
            string hexVal;
            int decimalVal;

            Console.Write("Input Hexadecimal Number: ");
            hexVal = Console.ReadLine();

            decimalVal = int.Parse(hexVal, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine($"\nHexadecimal number: {hexVal}");
            Console.WriteLine("Covert to--");
            Console.WriteLine($"Decimal number: {decimalVal}");
        }
    }
}
