using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem23
    {
        public static void mixedstring(string a,string b)
        {
            int minLength = Math.Min(a.Length, b.Length);
            string sum = string.Empty;

            for (int i = 0; i < minLength; i++)
            {
                sum += a[i].ToString() + b[i].ToString();
            }

            if (a.Length > b.Length)
            {
                sum += a.Substring(minLength);
            }
            else if (b.Length > a.Length)
            {
                sum += b.Substring(minLength);
            }

            Console.WriteLine(sum);
        }
    }
}
