using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    //Dutch National Flag Problem
    internal class Sort012
    {
        public void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public void SortOneTwo(int[] arr, int n)
        {
            //Approach 1-Counting Approach
            //int i, cnt0 = 0, cnt1 = 0, cnt2 = 0;
            ////Count number of 1's, 2's and 0's in the array
            //for(i =0; i < n; i++)
            //{
            //    switch(arr[i])
            //    {
            //        case 0:
            //            cnt0++;
            //            break;
            //        case 1:
            //            cnt1++;
            //            break;
            //        case 2:
            //            cnt2++;
            //            break;
            //    }
            //}
            ////update the array
            //i = 0;
            ////store all 0's in the beginning
            //while(cnt0 > 0)
            //{
            //    arr[i++] = 0;
            //    cnt0--;
            //}
            ////Then all 1's
            //while (cnt1 > 0)
            //{
            //    arr[i++] = 1;
            //    cnt1--;
            //}
            ////Then all 2
            //// Finally all the 2s
            //while (cnt2 > 0)
            //{
            //    arr[i++] = 2;
            //    cnt2--;
            //}

            //Approach 2: 2 Pointer Approach
            //We need to take three-pointers, low, mid, high. We will use low and mid pointers at the start, and the high pointer will point at the end of the given array.
            //If array[mid] = 0, then swap array[mid] with array[low] and increment both pointers once.
            //If array[mid] = 1, then no swapping is required.Increment mid pointer once.
            //If array[mid] = 2, then we swap array[mid] with array[high] and decrement the high pointer once.

            int low = 0;
            int mid = 0;
            int high = n - 1;
            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    swap(arr, low, mid);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 2) 
                {
                    swap(arr, mid, high);
                    high--;
                }
                else
                {
                    mid++;
                }
            }

        }
    }
}
