using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Вася", 45, 57573424);
            worker1.Print();

            Worker worker2 = new Worker("Petya", 36, 4684641642);
            worker2.Print();

            Worker worker3 = new Worker("Светлана", 23);
            worker3.Print();

            Worker worker4 = new Worker("Ирина");
            worker4.Print();

            Console.ReadLine();
        }
    }

    class Worker
    {
        public string name;
        private int age;
        public Int64 snn;

        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public Worker(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Worker(string name)
            : this(name, 25)
        {

        }
        public Worker(string name, int age, Int64 snn)
        {
            Name = name;
            Age = age;
            this.snn = snn;
        }

        public string Name { get { return name; } private set { /* проверка данных для имени*/} }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Неверно указан возраст.");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

}
