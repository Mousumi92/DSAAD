using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ReverseArray
    {
        public void PrintArray(int[] arr, int n)
        {
            for(int i = 0; i < n;i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }
        public void Reverse(int[] arr, int n)
        {
            int start = 0;
            int end = n - 1;

            while (start <= end)
            { 
                swap(arr, start, end);
                start++;
                end--;
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
