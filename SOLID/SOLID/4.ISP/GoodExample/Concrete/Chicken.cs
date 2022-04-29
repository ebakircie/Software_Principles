using SOLID._4.ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.GoodExample.Concrete
{
    public class Chicken:IWalkBird
    {
        public string Walk()
        {
            return "All chicken can walk...!";
        }
    }
}
