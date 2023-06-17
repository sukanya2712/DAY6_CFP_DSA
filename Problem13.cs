using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem13
    {
        public static string FullSequenceOfLetters(string letters)
        {
            char start = letters[0];
            char end = letters[1];

            string sequence = string.Empty;
            for (char letter = start; letter <= end; letter++)
            {
                sequence += letter;
            }

            return sequence;
        }
    }
}
