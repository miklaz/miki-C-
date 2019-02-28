using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class Square : Rectangle, Iprint
    {
        public Square(double side) : base(side, side)
        {
            this.Type = " вадрат";
        }
    }
}
