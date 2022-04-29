using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.BadExample
{
    public class Hawk:IBird
    {
        public string Fly()
        {
            return "All Hawks can fly...!";
        }

        public string Walk()
        {
            return "All Hawks can walk...!";
        }
    }
}
