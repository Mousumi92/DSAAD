using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class Fibonacci
    {
       public int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 2; i < n; i++)
            {
                int next = a + b;
                a = b;
                b = next;
            }
            return b;
        }


    }
}
