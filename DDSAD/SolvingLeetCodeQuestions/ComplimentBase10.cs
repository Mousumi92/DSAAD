using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetCodeQuestions
{
    internal class ComplimentBase10
    {
        //1st Approach
        public int BitwiseComplement(int n)
        {
            int m = n;
            int mask = 0;
            //edge case
            if (n == 0)
                return 1;
            while (m != 0)
            {
                mask = (mask << 1) | 1;
                m = m >> 1;
            }
            int ans = ~n & mask;
            return ans;
        }

        //2nd Approach
        //public int BitwiseComplement2(int n)
        //{
        //    int x = 1;
        //    //edge case
        //    if (n == 0)
        //        return 1;
        //    while (x<=n)
        //    {
        //       n = n ^ x;
        //       x = x<<1;
        //    }
        //    return n;
        //}
    }
}
