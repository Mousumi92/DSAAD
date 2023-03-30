using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSAD
{
    internal class WalkingExample
    {

        public void ReachHome(int src, int dest)
        {
            Console.WriteLine("Source " + src + " Destination " + dest);
            //Base Case

            if (src == dest)
            {
                Console.WriteLine("Reached Home");
                return;
            }
            //processing- increase step by 1
            src++;
            ReachHome(src, dest);
        }
    }
  
}
