using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class SwapAlternate
    {
        public void SwapAlternateElements(int[] arr, int size)
        { 
            for(int i =0; i< size; i= i+2)
            {
                if(i+1 < size)
                {
                    swap(arr, i, i + 1);
                }
            }
        }

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
    }
}
