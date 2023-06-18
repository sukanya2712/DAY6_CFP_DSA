using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class problem22
    {

       public static void addch(string word,string seperate)
        {
            string seperatedword = string.Empty;
            for(int i=0;i<word.Length; i++) 
            {
                seperatedword += word[i] + seperate ;

            }

            //return seperatedword;
            string words = string.Empty;
            for (int i=0;i<seperatedword.Length;i++)
            {
               Console.Write( words += seperatedword[i]);
            }

        }
    }
}
