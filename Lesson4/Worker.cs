using System;

namespace Lesson4
{
    public abstract class Worker : IPayTax
    {
        private string name;
        public string Name { get { return name; } private set { name = value; } }

        private int age;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 18 || value > 100)
                    Console.WriteLine("Ошибка ввода возраста");
                else
                    age = value;
            }
        }

        private Int64 snn;
        public Int64 SNN { get { return snn; } private set { snn = value; } }

        private double salary;
        public double Salary { get { return salary; } set { salary = value; } }


        public static int count;
        public Worker(string name, int age, Int64 snn)
        {
            // при первом создании экземлпяра здесь вызовется статический конструктор
            Name = name;
            Age = age;
            SNN = snn;
            Salary = 20000;
            count++;
        }

        static Worker()
        {
            count = 0;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("Зарплата: " + salary);
        }

        public abstract void CalculateSalary();

        public static void PrintAllWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].PrintInfo();
            }
        }

        public abstract double PayTax();
    }
}
