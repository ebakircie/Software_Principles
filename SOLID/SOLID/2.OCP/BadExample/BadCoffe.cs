using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2.OCP.BadExample
{
        public enum CoffeTypes { Latte = 1, Expresso = 2, FilterCoffee = 3 }

        public class BadCoffe
        {
            public double GetTotalPrice(double amount, CoffeTypes coffeTypes)
            {
                double totalPrice = 0;

                if (coffeTypes == CoffeTypes.Expresso)
                {
                    totalPrice += amount * 4.25;
                }
                else if (coffeTypes == CoffeTypes.FilterCoffee)
                {
                    totalPrice += amount * 1.25;
                }
                else if (coffeTypes == CoffeTypes.Latte)
                {
                    totalPrice += amount * 2.55;
                }

                return totalPrice;
            }
        }
}
