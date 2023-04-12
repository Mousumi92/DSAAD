using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class Subsets
    {
        public void FindSubsets(int index, IList<IList<int>> ans, int[] nums, List<int> output)
        {
            if (index >= nums.Length)
            {
                ans.Add(new List<int>(output));
                return;
            }

            // At every index we have 2 choices, take it or not take it.
            // Take the element at the current index.
            //include
            output.Add(nums[index]);
            FindSubsets(index + 1, ans, nums, output);

            //exclude
            // Remove the element from the list.
            output.Remove(nums[index]);
            FindSubsets(index + 1, ans, nums, output);
        }
    }
}
