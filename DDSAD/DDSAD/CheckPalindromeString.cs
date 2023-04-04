using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class CheckPalindromeString
    {
        public bool CheckPalindrome(char[] str, int i, int j)
        {
            if (i > j) return true; //base case
           
            if (str[i] != str[j])
                return false;

            else
            //Recursive call
            {
                return CheckPalindrome(str, i + 1, j - 1);
            }
        
        }
    }
}
