using System.Linq;

namespace DDSAD
{
    internal class SumOfArrayElements
    {
        public int GetSum(int[] arr, int size)
        {
            //base case
            if(size == 0) return 0;
            if(size == 1) return arr[0];
            int remainingPart = GetSum(arr.Skip(1).ToArray(), size-1);
            int sum = arr[0] + remainingPart;
            return sum;
        }
    }
}
