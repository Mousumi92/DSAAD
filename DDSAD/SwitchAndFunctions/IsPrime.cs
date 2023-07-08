using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class IsPrime
    {
        //TC -> O(n), loop runs n-2 times
        public bool IsPrimeNumber(int n)
        {
            for(int i =2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
