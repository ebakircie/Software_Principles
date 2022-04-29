using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2.OCP.GoodExample.Abstract
{
    public abstract class GoodCoffeShop
    {
        public abstract double GetTotalPrice(double amount);
    }
}
