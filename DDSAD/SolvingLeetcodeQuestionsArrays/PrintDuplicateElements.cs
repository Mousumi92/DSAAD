using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class PrintDuplicateElements
    {
        //https://leetcode.com/problems/find-all-duplicates-in-an-array/
        public IList<int> FindDuplicateArrayElements(int[] nums)
        {
            //Approach 1
            //Dictionary<int, int> map = new Dictionary<int, int>();
            //IList<int> list = new List<int>();
            //foreach (int num in nums)
            //{
            //    if (map.ContainsKey(num))
            //    {
            //        list.Add(num);
            //    }
            //    else
            //    { 
            //      map.Add(num, 1);
            //    }
            //}
            //return list;

            //Approach 2
            IList<int> list = new List<int>();
            Array.Sort(nums);
            for(int i = 1; i < nums.Length; i++) 
            {
                if (nums[i] == nums[i-1])
                {
                    list.Add(nums[i]);
                }
            }
            return list;
        }
    }
}
