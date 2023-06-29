using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetCodeQuestions
{
    internal class ReverseInteger
    {
        public int Reverse(int x)
        {
            int ans = 0;
            while (x != 0)
            {
                int digit = x % 10;
                ans = (ans * 10) + digit;
                if ((ans > Int32.MaxValue / 10) || (ans < Int32.MinValue / 10))
                {
                    return 0;
                }
                x = x / 10;
            }
            return ans;
        }
    }
}
