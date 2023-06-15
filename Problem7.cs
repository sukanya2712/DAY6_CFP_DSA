using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem7
    {
        public static double CalculateDoubleSum(object[] obj)
        {
            double sum = 0;

            /*foreach (object item in obj)
            {
                if (item is double)
                {
                    sum += (double)item;
                }
            }

            return sum;*/

            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] is double)
                {
                    sum += (double)obj[i];
                }
            }

            return sum;
        }
    }
}
