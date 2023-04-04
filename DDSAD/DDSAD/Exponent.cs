using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class Exponent
    {
       public int CalculatePower(int a, int b)
        {
            //base case
            if (b == 0) return 1;
            if (b == 1) return a;

            //Recursive call
            int ans = CalculatePower(a, b / 2);
            if(b % 2 == 0)
            {
                return ans * ans;
            }
            else
            {
                return a * ans * ans;
            }
        }
    }
}
