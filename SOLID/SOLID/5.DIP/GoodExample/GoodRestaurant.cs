using SOLID._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5.DIP.GoodExample
{
    public class GoodRestaurant
    { 
        //Encapsulation
        private IProduct _product;

        public GoodRestaurant(IProduct product)
        {
            this._product = product;
        }

        public string GetMenu()
        {
            return _product.GetCookingInstruction();
        }
    }
}
