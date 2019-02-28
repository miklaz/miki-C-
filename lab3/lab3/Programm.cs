using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

namespace lab3 //gg
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(7, 4);
            Square square = new Square(11);
            Circle circle = new Circle(9);

            Console.WriteLine("\nArrayList");
            ArrayList al = new ArrayList();
            al.Add(circle);
            al.Add(rect);
            al.Add(square);

            foreach (var x in al) Console.WriteLine(x);

            Console.WriteLine("\nArrayList - сортировка");
            al.Sort();
            foreach (var x in al) Console.WriteLine(x);

            ////////////////////////////////////////////////////////////////

            Console.WriteLine("\nList<Figure>");
            List<Figure> fl = new List<Figure>();
            fl.Add(circle);
            fl.Add(rect);
            fl.Add(square);

            Console.WriteLine("\nѕеред сортировкой:");
            foreach (var x in fl) Console.WriteLine(x);

            //сортировка
            fl.Sort();

            Console.WriteLine("\nѕосле сортировки:");
            foreach (var x in fl) Console.WriteLine(x);

            /////////////////////////////////////////////
            ///
            Console.WriteLine("\nћатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = square;
            matrix[2, 2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            //¬ыход за границы индекса и обработка исключени€
            try
            {
                Figure temp = matrix[123, 123, 123];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            /////////////////////////////////////////////////

            Console.WriteLine("\n–абота со списком");
            SimpleList<Figure> list = new SimpleList<Figure>();
            list.Add(circle);
            list.Add(rect);
            list.Add(square);
            Console.WriteLine("\nѕеред сортировкой:");
            foreach (var x in list) Console.WriteLine(x);
            //сортировка
            list.Sort();
            Console.WriteLine("\nѕосле сортировки:");
            foreach (var x in list) Console.WriteLine(x);

            ////////////////////////////////////////////////
            Console.WriteLine("\n—тек");

            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            //добавление данных в стек
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            //чтение данных из стека
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadLine();

        }
    }
}
