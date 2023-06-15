using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem2
    {
        public static bool Leap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}
