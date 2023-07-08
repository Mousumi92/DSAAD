using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class PowerOfaAndb
    {
        public int power(int a, int b)
        {
            int ans = 1;
            for(int i = 1; i <= b; i++)
            {
                ans = ans * a;
            }
            return ans;
        }
    }
}
