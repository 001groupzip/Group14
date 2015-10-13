using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Other
            /*int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("\nВведите индекс элемента массива меньше " + array.Length + ", который не будет выводиться на экране.");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Массив без " + temp + " элемента.");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == temp)
                {
                    Console.WriteLine("---");
                    continue; 
                }
                Console.WriteLine(array[i] + " ");
            }*/
            #endregion

            Random rand = new Random();

            int temp = rand.Next(1, 10);
            int[,] array = new int[temp, temp];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
