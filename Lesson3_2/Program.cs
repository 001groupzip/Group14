using System;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Белый", "Черный", "Синий", "Зеленый", "Желтый", "Красный" };
            Random rand = new Random();

            Shape[] shapes = new Shape[10];

            for (int i = 0; i < shapes.Length; i++)
            {
                if (i < 5)
                {
                    shapes[i] = new Square(rand.Next(-100, 100), rand.Next(-100, 100), colors[rand.Next(0, colors.Length - 1)], rand.Next(5, 15));
                }
                else
                {
                    shapes[i] = new Circle(rand.Next(-100, 100), rand.Next(-100, 100), colors[rand.Next(0, colors.Length - 1)], rand.Next(5, 15));
                }
            }

            foreach (Shape s in shapes)
            {
                s.PrintInfo();
                s.GetSquare();
                Console.WriteLine();
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].PrintInfo();
                shapes[i].GetSquare();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}