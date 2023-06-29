using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class PermutationsOfAString
    {
        public void Solve(int[] nums, IList<IList<int>> ans, int index, List<int> output)
        {
            //base case
            if (index >= nums.Length)
            {
                ans.Add(nums);
                return;
            }
            for (int j = index; j < nums.Length; j++)
            {
                Swap(nums, nums[index], nums[j]);
               // ans.Add(nums);
                Solve(nums, ans, index + 1, output);   
               //backtrack
                Swap(nums, nums[index], nums[j]);
            }
        }
        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i]= arr[j];
            arr[j] = temp;
        }
    }
}
