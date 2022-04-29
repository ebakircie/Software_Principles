using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.BadExample
{
    public class BadSquare
    {
        int _length;
        public override int Length { get => _length; set => _length = value; }

        int _width;
        public override int Width { get => _width; set => _width = value; }
    }
}
