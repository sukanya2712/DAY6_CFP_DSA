using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem14
    {
        public static int StrictlyIncrease(int[] arr)
        {
            int maxLength = 0;  // Length of the longest strictly increasing sequence
            int currentLength = 0;  // Length of the current sequence

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 0;
                }
            }

            return Math.Max(maxLength, currentLength);
        }
    }
}
