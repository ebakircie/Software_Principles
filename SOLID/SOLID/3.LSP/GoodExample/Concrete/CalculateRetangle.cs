using SOLID._3.LSP.GoodExample.Abstract;
using SOLID._3.LSP.GoodExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.GoodExample.Concrete
{
    public class CalculateRetangle:Calculate<Retangle>
    {
        public override int CalculateArea(Retangle entity)
        {
            return entity.Edge * entity.Length;
        }
    }
}
