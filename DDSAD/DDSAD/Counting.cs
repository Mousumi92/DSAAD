using System;

namespace DDSAD
{
    internal class Counting
    {
       public void PrintCount(int n)
        {
            if(n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintCount(n-1);
        }
    }
}
