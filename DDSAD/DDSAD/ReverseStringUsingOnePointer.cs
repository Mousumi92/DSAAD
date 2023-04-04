using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class ReverseStringUsingOnePointer
    {

        public void ReverseUsingOnePointer(char[] str, int i)
        {
            Console.WriteLine("Call received for " + new string(str));
            //base case
            int n = str.Length;
            if (i == n/2)
                return;
            swap(str, i, n-i-1);
            i++;
            //Recursive call
            ReverseUsingOnePointer(str, i);
        }

        public void swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
