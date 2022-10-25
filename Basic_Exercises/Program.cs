using System;
using System.Collections.Generic;
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
            string text, word;

            Console.Write("Enter a line of text: ");
            text = Console.ReadLine();
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);
            word = "";
            int ctr = 0;

            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                } 
            }

            Console.WriteLine($"\n{word}");
        }
    }
}
