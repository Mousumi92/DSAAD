using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class FindIntersectionOfArrayElements
    {
        //https://www.codingninjas.com/studio/problems/intersection-of-2-arrays_1082149?source=youtube&campaign=love_babbar_codestudio1&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio1
        public IList<int> IntersectedArrayElement(int[] arr1, int[] arr2, int n, int m)
        {
            //Approach 1
            //As soon as you find the intersected element, update the value in arr 2 and break
            //IList<int> arr = new List<int>();
            //for(int i = 0; i < n; i++)
            //{
            //    int element = arr1[i];
            //    for(int j = 0; j < m; j++)
            //    {
            //        if (element < arr2[j])
            //            break;

            //        if(element == arr2[j])
            //        {
            //            arr.Add(element);
            //            arr2[j] = Int32.MinValue;
            //            break;
            //        }
            //    }
            //}
            //return arr;
            //Approach 2
            int i = 0, j = 0;
            IList<int> ans = new List<int>();
            while(i < n && j < m)
            {
                if (arr1[i] == arr2[j])
                {
                    ans.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if(arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return ans;
        }
    }
}
