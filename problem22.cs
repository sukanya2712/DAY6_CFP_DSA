using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class problem22
    {

       public static string  addch(string word,string seperate)
        {
            string seperatedword = string.Empty;
            for(int i=0;i<word.Length; i++) 
            {
                seperatedword += word[i] + seperate ;

            }

            return seperatedword;
            

        }
    }
}
