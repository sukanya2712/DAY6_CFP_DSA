using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem15
    {
        public static int BitsToNumber(string bits)
        {
            var sum = 0;
            for(int i = 0; i < bits.Length; i++) {
                
              
                    sum += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i - 1));
                
            }
           return sum;
        }

    }
}
