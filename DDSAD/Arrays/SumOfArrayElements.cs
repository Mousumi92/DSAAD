using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SumOfArrayElements
    {
        public int CalculateSumOfArrayElements(int[] num, int n)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            return sum;
        }
    }
}
