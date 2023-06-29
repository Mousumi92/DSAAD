using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    internal class BinaryToDecimal
    {
        public double ConvertBinaryToDecimal(int n)
        {
            double ans = 0;
            int i = 0;
            while (n != 0)
            {
                int digit = n % 10;
                ans = (digit * Math.Pow(2, i)) + ans;
                n = n / 10;
                i = i + 1;
            }
            return ans;
        }
    }
}
