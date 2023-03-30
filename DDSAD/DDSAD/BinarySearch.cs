using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class BinarySearch
    {

        void PrintArray(int[] arr, int start, int end)
        {
            for (int i = start; i<= end; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        public bool FindUsingBinarySearch(int[] arr, int start, int end, int key)
        {
            PrintArray(arr, start, end);
            int mid = start +(end - start) / 2;
            Console.WriteLine("Value of mid array is: " + arr[mid]);
            //base case
            if (start > end) return false;// key not found
            if (arr[mid] == key) return true;// key found

            if (arr[mid] < key)
            {
                return FindUsingBinarySearch(arr, mid + 1, end, key);
            }
            else
            {
                return FindUsingBinarySearch(arr, start, mid - 1, key);
            }

        }
    }
}
