using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetCodeQuestions
{
    internal class PowerOf2
    {
        //Approach 1
        public bool IsPowerOfTwo(int n)
        {
            for (int i = 0; i <= 30; i++)
            {
                int ans = (int)Math.Pow(2, i);
                if (ans == n)
                {
                    return true;
                }
            }
            return false;
        }

        //Approach 2
        //public bool IsPowerOfTwo(int n)
        //{
        //    int ans = 1;
        //    for (int i = 0; i <= 30; i++)
        //    {
        //        if (ans == n)
        //        {
        //            return true;
        //        }
        //        if (ans < (Int32.MaxValue / 2))
        //            ans = ans * 2;
        //    }
        //    return false;
        //}

        //Approach 3
        // n & n-1 flips the righmost set bit
        //public bool IsPowerOfTwo(int n)
        //{
        //    if(n<=0)
        //        return false;
        //    return (n & (n-1)) == 0
        //}
    }
}
