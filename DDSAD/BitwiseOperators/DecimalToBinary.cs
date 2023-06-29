using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    internal class DecimalToBinary
    {
        public double ConvertDecimalToBinary(int n)
        {
            double ans = 0;
            int i = 0;
            while (n != 0)
            {            
               int bit = n & 1;
               ans = (bit * Math.Pow(10, i)) + ans;
               n = n >> 1;
               i= i+1;
            }
            return ans;
        }
    }
}
