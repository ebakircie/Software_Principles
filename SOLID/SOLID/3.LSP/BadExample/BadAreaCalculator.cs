using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.BadExample
{
    public class BadAreaCalculator
    {
        public static int CalculateArea(BadRetangle badRetangle)
        {
            return badRetangle.Width * badRetangle.Length;
        }

        public static int CalculateArea(BadSquare badSquare)
        {

            return badSquare.Width * badSquare.Length;
        }
    }
}
