using SOLID._4.ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.GoodExample.Concrete
{
    public class Hawk : IWalkBird, IFlyBird
    {
        public string Fly()
        {
            return "All hawks can fly...!";
        }

        public string Walk()
        {
            return "All hawks can walk...!";

        }
    }
}
