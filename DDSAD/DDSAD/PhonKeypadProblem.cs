using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class PhonKeypadProblem
    {
        public void solve(string digits, string output, int index, IList<string> ans, string[] mapping)
        {
            //base case
            if (index >= digits.Length)
            {
                ans.Add(output);
                return;
            }
            //subtract from 0 to get the integer number
            int number = digits[index] - '0';
            //get mapping value of the number
            string value = mapping[number];
            for (int i = 0; i < value.Length; i++)
            {
                //add the element to the string
                char element = value[i];
                StringBuilder sb = new StringBuilder(output);
                sb.Append(element);
                output = sb.ToString();
               
                solve(digits, output, index + 1, ans, mapping);
                //Remove the last elemt added
                sb.Remove(output.Length - 1, 1);
                output = sb.ToString();
            }
        }
    }
}
