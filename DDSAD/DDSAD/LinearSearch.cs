using System;
using System.Linq;

namespace DDSAD
{
    internal class LinearSearch
    {

        void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public bool FindKey(int[] arr, int size, int key)
        {
            PrintArray(arr, size);
            if (size == 0)
                return false;
            if (arr[0] == key) 
                return true;
            else
            {
                bool isKeyFound = FindKey(arr.Skip(1).ToArray(), size -1, key);
                return isKeyFound;
            }

        }
    }
}
