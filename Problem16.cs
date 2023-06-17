using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem16
    {
        public static void Triangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10-i-1; j++)  
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i+1; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

