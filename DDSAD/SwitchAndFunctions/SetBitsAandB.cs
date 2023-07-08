using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class SetBitsAandB
    {
       public int setBitsB(int b)
        {
            int count = 0;
            while (b != 0)
            {
                if ((b & 1) == 1)
                {
                    count++;
                }
                b = b >> 1;
            }
            return count;
        }

       public int setBitsA(int a)
        {
            int count = 0;
            while (a != 0)
            {
                if ((a & 1) == 1)
                {
                    count++;
                }
                a = a >> 1;
            }
            return count;
        }
    }
}
