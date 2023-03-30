using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class PowerOfn
    {
       public int CalculatePower(int n)
        {
            if (n == 0)
                return 1;
            //Recursive Relation
            return 2 * CalculatePower(n - 1);

        }
    }
}
