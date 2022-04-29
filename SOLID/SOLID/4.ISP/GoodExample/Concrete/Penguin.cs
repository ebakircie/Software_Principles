using SOLID._4.ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.GoodExample.Concrete
{
    public class Penguin : IWalkBird, ISwimBird
    {
        public string Swim()
        {
            return "All penguins can swim...!";
        }

        public string Walk()
        {
            return "All penguins can walk...";
        }
    }
}
