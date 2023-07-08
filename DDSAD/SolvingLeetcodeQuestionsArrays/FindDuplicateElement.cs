using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class FindDuplicateElement
    {
        //https://www.codingninjas.com/studio/problems/duplicate-in-array_893397?source=youtube&campaign=love_babbar_codestudio1&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio1
        public int FindDuplicateArrayElement(int[] arr)
        {
            int ans = 0;
            //XOR of all array elements
            for(int i = 0; i < arr.Length; i++)
            {
                ans = ans ^ arr[i];
            }
            //XOR of elements from [1..n-1]
            for(int i = 1; i< arr.Length; i++)
            {
                ans = ans ^ i;
            }
            return ans;
        }
    }
}
