using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem1
    {
        public static void swap()
        {
            int a = 23;
            int b = 30;

            int temp;

            Console.WriteLine("Before swapping : ");
            Console.WriteLine("a is : "+a + " ");
            Console.WriteLine("b is : "+b);

            temp = b;
            b = a;
            a = temp;

            Console.WriteLine("After swapping : ");
            Console.WriteLine("a is : "+a + " ");
            Console.WriteLine("b is : "+b);
        }
    }
}
