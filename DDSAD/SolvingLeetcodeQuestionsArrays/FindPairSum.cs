using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class FindPairSum
    {
        //https://www.codingninjas.com/studio/problems/pair-sum_697295?source=youtube&campaign=love_babbar_codestudio1&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio1
        public IEnumerable<List<int>> PairSum(int[] arr, int s)
        {
            List<List<int>> ans = new List<List<int>>();
            //Why are we running the outer loop until n - 2? The idea is simple: We don't need to consider the last element in the outer loop since it would have already been checked with all the previous elements.
            //Why are we starting the inner loop from i + 1? This will help us ensure that each pair of elements is considered only once, so we avoid checking pairs that have already been checked before.
           
            //Approach 1
            //for(int i =0; i < arr.Length-1; i++)
            //{
            //    for(int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i]+ arr[j] == s)
            //        {
            //            List<int> temp = new List<int>();
            //            temp.Add(Math.Min(arr[i], arr[j]));
            //            temp.Add(Math.Max(arr[i], arr[j]));
            //            ans.Add(temp);
            //        }
            //    }
            //}

            //Approach 2
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if(sum == s)
                {
                    List<int> temp = new List<int>();
                    temp.Add(Math.Min(arr[left], arr[right]));
                    temp.Add(Math.Max(arr[left], arr[right]));
                    ans.Add(temp);
                    left = left + 1;
                    right = right - 1;
                }
                else if(sum < s)
                {
                    left = left + 1;
                }
                else
                {
                    right = right - 1;
                }

            }
            //to sort the list
            IEnumerable<List<int>> rlist = ans.Select(
            lst => lst.OrderBy(i => i).ToList());
            return rlist;
        }
    }
}
