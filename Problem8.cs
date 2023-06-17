using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem8
    {
        public static void sieve()
        {
            //print prime no bet 2 to 100
            Console.WriteLine("Prime numbers between 2 and 100:");
            for (int number = 2; number <= 100; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }

            static bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
