using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem3
    {
        public static bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}
