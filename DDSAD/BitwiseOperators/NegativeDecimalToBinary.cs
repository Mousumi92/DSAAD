using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    internal class NegativeDecimalToBinary
    {
        public double ConvertNegativeDecimalToBinary(int n)
        {
            double ans = 0;
            int i = 0;
            int onesCompAns = 0;
            if(n < 0)
            {
                n = n * -1;
            }
            while (n != 0)
            {
                int bit = n & 1;
                ans = (bit * Math.Pow(10, i)) + ans;
                //for one's compliment
                int testBit = bit;
                if (testBit == 0)
                {
                    testBit = 1;
                }
                else
                {
                    testBit = 0;
                }
                onesCompAns = Convert.ToInt32((testBit * Math.Pow(10,i)) + onesCompAns);
                n = n >> 1;
                i = i + 1;
            }
            //two's compliment
            int twosCompliment = onesCompAns | 1;
            return twosCompliment;
        }
    }
}
