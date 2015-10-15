using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public sealed class Manager : Worker
    {
        public int ProjectsCount;

        public Manager(string name, int age, Int64 snn, int projCount)
            : base(name, age, snn)
        {
            ProjectsCount = projCount;
            CalculateSalary();
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Количество проектов: " + ProjectsCount);
            Console.WriteLine("Налоги: " + PayTax());
            Console.WriteLine();
        }
        public override void CalculateSalary()
        {
            Salary = ProjectsCount * 12000;
        }

        public override double PayTax()
        {
            return Salary * 0.13;
        }
    }
}
