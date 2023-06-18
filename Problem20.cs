using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem20
    {
        public static int digitroot(int number)
        {
            while (number >= 10)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            return number;


        }
           

    }
}