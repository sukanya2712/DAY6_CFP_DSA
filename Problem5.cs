using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem5
    {
        public static int DigitsSum(int number)
        {
            
                int sum = 0;

                while (number != 0)
                {
                    int digit = number % 10; 
                    sum += digit; 
                    number /= 10; 
                }

                return sum;
            
        }
    }
}
