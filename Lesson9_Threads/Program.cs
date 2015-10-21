using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9_Threads
{
    /*
     * Имеется барабан с 3 колесами. На каждом колесе может выпасть число от 0 до 9
     * Число выбирается выбирается случайным образом.
     * 
     * Создать по отдельному потоку под каждое "колесо";
     * 
     * 7 8 5
     * 
     * Если вывелось 3 одинаковых числа --> JackPot!!!
     * 
     * Вращение барабана запускается "run".
     * 
     * Все работает до тех пор, пока пользователь не наберет "exit".
     */


    class Program //запуск простых потоков
    {
        static void Main(string[] args)
        {
            /*ThreadStart start = Test; //для непараметризованного метода
            Thread thread1 = new Thread(start);
            thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.AboveNormal;
            thread1.Name = "Первый поток";
            thread1.Start();*/

            ParameterizedThreadStart start = Test; //для параметризованного метода
            Thread thread1 = new Thread(start);
            thread1.IsBackground = true;
            thread1.Start(new int[] { 10, 20 });

            while (Console.ReadLine() != "exit") { }
        }

        static void Test(object obj)
        {
            int[] array = (int[])obj;
            int a = array[0];
            int b = array[1];
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
