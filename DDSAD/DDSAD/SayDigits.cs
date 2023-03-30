using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class SayDigits
    {
        public void sayDigit(int n, string[] arr)
        {
            if (n == 0) //When there is no digit left
                return;

            //Processing
            int digit = n % 10;
            n = n / 10;

            //Recursive call
            sayDigit(n, arr);
            Console.Write(arr[digit]+ " ");
        }
    }
}
