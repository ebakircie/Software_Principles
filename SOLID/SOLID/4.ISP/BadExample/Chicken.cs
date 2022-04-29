using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.BadExample
{
    public class Chicken:IBird
    {   // Since Chickens cant fly, they inherited Fly method unncessary and this is against the ISP
        public string Fly()
        {
            return " All chickens can't fly...";
        }

        public string Walk()
        {
            return "All chickens can walk...!";
        }
    }
}
