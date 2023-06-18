using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem24
    {
        public static void countno(string sentence)
        {
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count+1);
        }
    }
}
