using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem9
    {
        public static void HourGlass()
        {
            for (int i = 5; i > 0; i--)
            {
                //spaces
                for (int j = 5 - i; j >= 1; j--)
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

            //lowercase
            for (int i = 1;i<=5; i++)
            {
                //spaces
                for (int j = 1;j<=5-i;j++)
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
