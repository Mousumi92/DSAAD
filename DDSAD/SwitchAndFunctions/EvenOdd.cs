using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class EvenOdd
    {
        public bool IsEven(int n)
        {
            //odd
            if ((n&1)== 1) return false;
            return true;
        }
    }
}
