using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem17
    {
        public static double ToThePowerOf(int baseNumber, int exponent)
        {
            if (exponent == 0)
                return 1;

            double result = 1;
            int absExponent = Math.Abs(exponent);

            for (int i = 0; i < absExponent; i++)
            {
                result *= baseNumber;
            }

            return exponent >= 0 ? result : 1 / result;
        }
    }
}
