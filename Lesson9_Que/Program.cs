using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9_Que
{
    class Program //проблема параллелизма
    {
        static Queue<int> queue;
        static object block = new object();
        static void Main(string[] args)
        {
            queue = new Queue<int>();
            for (int i = 1; i <= 100; i++)
            {
                queue.Enqueue(i);
            }

            Action<int> workItem = CalcQueItem;
            workItem.BeginInvoke(1, null, null);
            workItem.BeginInvoke(2, null, null);

            Console.ReadLine();
        }

        static void CalcQueItem(int id)
        {
            while (queue.Count != 0)
            {
                int number = -1;
                Thread.Sleep(10);

                lock(block)
                {
                    number = queue.Dequeue();
                    number *= number;
                }
                

                Console.WriteLine("{0} - {1}", id, number);
            }
        }
    }
}
