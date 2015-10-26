using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Task
{
    class Program
    {
        static int[] counts;
        static void Run(int seed, int i)
        {
            Random rnd = new Random(seed);
            counts[i] = rnd.Next(10);
        }


        static void Main(string[] args)
        {
            counts = new int[3];
            Action<int, int> act = Run;
            for (int i = 0; i < 3; i++)
            {
                act.BeginInvoke(new Random().Next(10) * 1653116 + 654261, i, null, null);
            }
            Console.WriteLine("Очки на барабане:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(counts[i] + " ");
            }
            Console.WriteLine();
            if (counts[0] == counts[1] && counts[1] == counts[2])
            {
                Console.WriteLine("JackPot!");
            }
            else
            {
                Console.WriteLine("Вы ничего не выйграли");
            }
        }
    }
}
