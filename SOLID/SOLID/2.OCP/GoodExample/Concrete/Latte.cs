using SOLID._2.OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2.OCP.GoodExample.Concrete
{
    public class Latte:GoodCoffeShop
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 3.20;
        }
    }
}
