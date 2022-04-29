using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.GoodExample.Abstract
{
    public abstract class Calculate<T>
    {
        public abstract int CalculateArea(T entity);
    }
}
