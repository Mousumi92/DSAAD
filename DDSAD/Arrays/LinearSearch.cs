using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class LinearSearch
    {
        //TC-> O(n)
       public bool Search(int[] arr, int size, int key)
        {
            for(int i=0; i < size; i++) 
            {
                if (arr[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
