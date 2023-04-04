using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class ReverseString
    {
       public void Reverse(char[] str, int i, int j)
        {
            Console.WriteLine("Call received for " + new string(str));
            //base case
            if (i > j)
                return;
            swap(str, i, j);
            i++;
            j--;
            //Recursive call
            Reverse(str, i, j);
        }

       public void swap(char[] arr,  int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
