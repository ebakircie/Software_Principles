using SOLID._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5.DIP.GoodExample.Concrete
{
    public class Chicken:IProduct
    {
        public string GetCookingInstruction()
        {
            return "Chicken Grill Recipes";
        }
    }
}
