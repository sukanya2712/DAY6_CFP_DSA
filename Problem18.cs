using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAC
{
    internal class Problem18
    {

        public static bool LettersBalance(string word)
        {
            bool isBalanced;
            for (int i = 0; i < word.Length / 2; i++)
            {
                isBalanced = false;
                for (int j = word.Length - 1; j >= word.Length / 2; j--)
                {
                    if (word[i] == word[j])
                    {
                        isBalanced = true;
                    }
                }

                if (!isBalanced)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
