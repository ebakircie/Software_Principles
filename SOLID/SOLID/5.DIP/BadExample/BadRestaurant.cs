using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5.DIP.BadExample
{
    public class BadRestaurant
    {
        BadFish badFish = new BadFish();

        BadPoultry BadPoultry = new BadPoultry();

        public string GetMenu()
        {
            return badFish.GetFishCookingInstructor() + "\n" + BadPoultry.GetPoultryCookingInstructor();
        }
    }
}
