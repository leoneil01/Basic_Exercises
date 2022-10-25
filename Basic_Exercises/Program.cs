using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, K, F;

            Console.Write("Enter the amount of celsius: ");
            C = Convert.ToDouble(Console.ReadLine());

            K = C + 273.15; // Celsius to Kelvin Formula
            F = (C * 9 / 5) + 32; // Celsius to Fahrenheit Formula
            //F = (K - 273.15) * 9 / 5 + 32; (Kelvin to Fahrenheit Formula)
            Console.WriteLine($"\nKelvin = {K}");
            Console.WriteLine($"Fahrenheit = {F}");
        }
    }
}
