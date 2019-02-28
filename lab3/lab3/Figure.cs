using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    public abstract class Figure : IComparable
    {
        /// <summary>
        /// “ип фигуры 
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// ¬ычисление площади фигуры 
        /// </summary>
        public abstract double Area();

        /// <summary>
        /// —равнение элементов (дл€ сортировки)
        /// </summary>
        public int CompareTo(object obj)
        {
            //ѕриведение параметра к типу "фигура"
            Figure test = (Figure)obj;
            if (this.Area() < test.Area()) return -1;
            else if (this.Area() == test.Area()) return 0;
            else return 1;
        }
    }
}
