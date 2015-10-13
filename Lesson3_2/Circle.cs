using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    class Circle : Shape
    {
        private int r;
        public int R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
                else
                    r = 1;
            }
        }

        public Circle(int x, int y, string color, int r)
            : base(x, y, color)
        {
            R = r;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Радиус: " + r);
        }

        public override void GetSquare()
        {
            Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(r, 2));
        }
    }
}
