using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem11
    {
        public static void ChirstmasTree()
        {
            for (int n = 0; n <3; n++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    //spaces
                    for (int j = 1; j <= 5 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    //stars
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
