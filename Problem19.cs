using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem19
    {
        public static string ReplaceWords(string word, char ch)
        {
            string firstWord = string.Empty;
            string secondWord = string.Empty;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] != ch)
                {
                    secondWord += word[i];
                }
                else
                {
                    for (int j = i + 1; j <= word.Length - 1; j++)
                    {
                        firstWord += word[j];
                    }
                    break;
                }
            }


            return firstWord + ch + secondWord;
        }
    }
}
