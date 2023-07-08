using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class FindUniqueElement
    {
        //https://www.codingninjas.com/studio/problems/find-unique_625159?source=youtube&campaign=love_babbar_codestudio1&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio1
        public int FindUniqueArrayElement(int[] arr, int size)
        {
            int ans = 0;
            for (int i=0; i<size; i++)
            {
                ans = ans^ arr[i];
            }
          return ans;
        }
    }
}
