using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem27
    {
        public static void countocc(string sen,string word)
        {
            int count = 0;
            string[] temp = sen.Split(" ");
            for(int i=0; i<temp.Length; i++)
            {
                if (word.Equals(temp[i])){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
