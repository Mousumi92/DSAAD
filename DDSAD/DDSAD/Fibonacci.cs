using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class Fibonacci
    {

        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            int ans = Fib(n - 1) + Fib(n - 2);
            return ans;
        }
    }
}
