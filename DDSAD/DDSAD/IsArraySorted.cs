using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class IsArraySorted
    {
        public bool IsSorted(int[] arr, int size)
        {
            if (size == 0 || size == 1) return true;
            if (arr[0] > arr[1])
                return false;
            else
            {             
                bool ans = IsSorted(arr.Skip(1).ToArray(), size - 1);
                return ans;
            }
        }
    }
}
