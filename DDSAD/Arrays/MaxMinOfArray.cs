using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MaxMinOfArray
    {
        //TC-> O(n)
        public int GetMax(int[] num, int n)
        {
            int max = Int32.MinValue;
            for(int i =0; i<n; i++)
            {
                if (num[i] > max)
                { 
                    max = num[i]; 
                }
            }
            return max;
        }

        public int GetMin(int[] num, int n)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            return min;
        }
    }
}
