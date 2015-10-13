using System;

namespace Lesson3_2
{
    abstract class Shape
    {
        protected int x, y;
        protected string color;

        public Shape(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Координата фигуры по X: " + x);
            Console.WriteLine("Координата фигуры по Y: " + y);
            Console.WriteLine("Цвет фигуры: " + color);
        }

        public abstract void GetSquare();

    }

    class Square : Shape
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                    a = 1;
            }
        }

        public Square(int x, int y, string color, int a)
            : base(x, y, color)
        {
            A = a;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Сторона квадрата: " + a);
        }

        public override void GetSquare()
        {
            Console.WriteLine("Площадь квадрата = " + Math.Pow(a, 2));
        }
    }
}