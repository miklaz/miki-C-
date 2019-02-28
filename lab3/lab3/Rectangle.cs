using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    public class Rectangle : Figure, Iprint
    {
        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        double height;

        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        double width;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="h">Высота</param>
        /// <param name="w">Ширина</param>
        public Rectangle(double h, double w)
        {
            this.height = h;
            this.width = w;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Площадь прямоугольника 
        /// </summary>
        public override double Area()
        {
            double Result = this.height * this.width;
            return Result;
        }

        /// <summary>
        /// Переопределение виртуального метода класса object, приведение всего этого безобразия к строке 
        /// </summary>
        public override string ToString()
        {
            return this.Type + " c высотой " + this.height.ToString() + " и шириной "
                       + this.width.ToString() + " имеет площадь " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

