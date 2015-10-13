using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public sealed class Driver : Worker
    {
        private string carType;
        public string CarType { get { return carType; } private set { carType = value; } }

        private int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Ошибка ввода времени работы водителя");
                else
                    hours = value;
            }
        }

        public Driver(string name, int age, Int64 snn, string carType, int hours)
            : base(name, age, snn)
        {
            CarType = carType;
            Hours = hours;
            CalculateSalary();
        }

        public override void CalculateSalary()
        {
            Salary = hours * 1500;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Часы: " + hours);
            Console.WriteLine("Налоги: " + PayTax());
            Console.WriteLine();
        }

        public override double PayTax()
        {
            return Salary * 0.07;
        }
    }

}
