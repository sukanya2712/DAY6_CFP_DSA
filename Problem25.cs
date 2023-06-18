using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem25
    {
        public static void RevertWordsOrder(string input)
        {
            
            string[] words = input.Split(' ');

            
            Array.Reverse(words);

            
            string output = string.Join(' ', words);

            
            if (input.EndsWith("."))
            {
                output += ".";
            }

            Console.WriteLine(output);
        }

    }
}
