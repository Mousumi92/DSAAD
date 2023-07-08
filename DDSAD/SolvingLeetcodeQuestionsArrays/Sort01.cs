using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class Sort01
    {
        public void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void SortOne(int[] arr, int n)
        {
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                while (arr[left] == 0)
                {
                    left++;
                }
                while (arr[right] == 1)
                {
                    right--;
                }
                swap(arr, left, right);
                left++;
                right--;
            }
        }

        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
