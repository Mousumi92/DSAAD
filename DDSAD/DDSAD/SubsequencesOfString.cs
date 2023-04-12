using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class SubsequencesOfString
    {
        public void FindSubsequences(int index, IList<string> ans, string str, string output)
        {
            if (index >= str.Length)
            {
                ans.Add(output);
                return;
            }
            //exclude
            FindSubsequences(index + 1, ans, str, output);

            // At every index we have 2 choices, take it or not take it.
            // Take the element at the current index.
            //include
            char[] charArray = str.ToCharArray();
            char element = charArray[index];
            StringBuilder sb = new StringBuilder(output);
            sb.Append(element);
            output = sb.ToString();

            FindSubsequences(index + 1, ans, str, output);         
        }
    }
}
