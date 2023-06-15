using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem6
    {
        public static void CalculateSumAndAverage(int n, int m)
        {
            int sum = 0;
            int count = 0;
            double average = 0;

            for (int i = n; i <= m; i++)
            {
                sum += i;
                count++;
            }

            average = sum / count;

            Console.WriteLine("sum is : " + sum);
            Console.WriteLine("avg is : " + average);
        }
    }
}
