using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;

namespace Lesson7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowList();

            //ShowDict();

            //ShowStack();

            //ShowQueue();

            //DPoint p1 = new DPoint(5, 87465.32);
            //p1.Print();
            //
            //SPoint p2 = new SPoint("Работник1", 94865.55);
            //p2.Print();

            Point<int, double> p1 = new Point<int, double>(5, 87465.32);
            p1.Print();

            Point<string, double> p2 = new Point<string, double>("646Рj", 94865.55);
            p2.Print();
            
        }

        private static void ShowQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine();

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();
            Console.WriteLine(queue.Count);
        }

        private static void ShowStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            int x = stack.Peek(); //stack.Pop();
            //Console.WriteLine(x);

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Count);


            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine(stack.Count);
        }

        private static void ShowDict()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add(".exe", 0);
            dict.Add(".txt", 0);

            dict[".txt"] += 1;
        }

        private static void ShowList()
        {
            Worker[] workersArray = new Worker[4] 
            { 
                new Driver("Водитель1", 30, 12345678, "Мерседес", 400),
                new Driver("Водитель2", 46, 12312312, "Volvo", 256),
                new Manager("Менеджер1", 25, 4444444, 10),
                new Manager("Менеджер2", 31, 55555555, 8)
            };

            /*foreach (Worker worker in workersArray)
            {
                worker.PrintInfo();
            }*/

            /*ArrayList list = new ArrayList();
            list.Add(new Driver("Водитель1", 30, 12345678, "Мерседес", 400));
            list.Add(new Driver("Водитель2", 46, 12312312, "Volvo", 256));
            list.Add(new Manager("Менеджер1", 25, 4444444, 10));
            list.Add(new Manager("Менеджер2", 31, 55555555, 8));

            

            Console.WriteLine(list.Count);

            list.Add("Rabotnik");

            foreach (object worker in list)
            {
                (worker as Worker).PrintInfo();
            }*/

            List<Worker> list = new List<Worker>();
            list.Add(new Driver("Водитель0", 30, 986351615, "Мерседес", 400));
            list.AddRange(workersArray);

            foreach (Worker item in list)
            {
                item.PrintInfo();
            }
            list.Reverse();
        }
    }

    class Point<T, M> //where T: class
    {
        public T x;
        public M y;

        public Point(T x, M y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class DPoint
    {
        public int x;
        public double y;

        public DPoint(int x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class SPoint
    {
        public string x;
        public double y;

        public SPoint(string x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
