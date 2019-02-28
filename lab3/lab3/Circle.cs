using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class Circle : Figure, Iprint
    {
        /// <summary>
        /// –адиус  руга 
        /// </summary>
        double radius;

        public Circle(double r)
        {
            this.radius = r;
            this.Type = " руг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }

        /// <summary>
        /// ѕереопределение виртуального метода класса object, приведение всего этого безобрази€ к строке 
        /// </summary>
        public override string ToString()
        {
            return this.Type + " c радиусом " + this.radius.ToString() +
                        " имеет площадь " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
