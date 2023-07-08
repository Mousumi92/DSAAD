using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class TripletsWithGivenSum
    {
        public IEnumerable<List<int>> TripletSum(int[] arr, int s)
        {
            List<List<int>> ans = new List<List<int>>();
           
            //Approach 1
            //for (int i = 0; i < arr.Length - 2; i++)
            //{
            //    for (int j = i + 1; j < arr.Length-1; j++)
            //    {
            //        for (int k = j + 1; k < arr.Length; k++)
            //        {
            //            if (arr[i] + arr[j]+ arr[k] == s)
            //            {
            //                List<int> temp = new List<int>();
            //                temp.Add(arr[i]);
            //                temp.Add(arr[j]);
            //                temp.Add(arr[k]);
            //                ans.Add(temp);
            //            }
            //        }
            //    }
            //}
            //Approach 2
            Array.Sort(arr);
           
            /* Now fix the first element
            one by one and find the
            other two elements */
            for (int i = 0; i < arr.Length - 2; i++)
            {
                // To find the other two elements,
                // start two index variables from
                // two corners of the array and
                // move them toward each other
                int left = i+1;
                int right = arr.Length - 1;
                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];
                    if (sum == s)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(arr[i]);
                        temp.Add(arr[left]);
                        temp.Add(arr[right]);
                        ans.Add(temp);
                        left = left + 1;
                        right = right - 1;
                    }
                    else if (sum < s)
                    {
                        left = left + 1;
                    }
                    else
                    {
                        right = right - 1;
                    }
                }

            }
            //to sort the list
            IEnumerable<List<int>> rlist = ans.Select(
            lst => lst.OrderBy(i => i).ToList());
            return rlist;
        }
    }
}
