using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class nCr
    {
       public int factorial(int n)
        {
            int fact = 1;
            for(int i = 1 ; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public int CalculatenCr(int n , int r)
        {
            int num = factorial(n);
            int den = factorial(r) * factorial(n - r);
            return num / den;
           
        }
    }
}
