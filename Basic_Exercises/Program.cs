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
            int index1, index2, index3;
            string name;

            Console.Write("Enter a word: ");
            name = Console.ReadLine();
            Console.Write("Enter the first index that you want to remove from the word that you input: ");
            index1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second index that you want to remove from the word that you input: ");
            index2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third index that you want to remove from the word that you input: ");
            index3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(remove_char(name, index1));
            Console.WriteLine(remove_char(name, index2));
            Console.WriteLine(remove_char(name, index3));
        }

        public static string remove_char(string name, int index)
        {
            return name.Remove(index, 1);
        }
    }
}
