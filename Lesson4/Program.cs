using System;
using System.Collections.Generic;

namespace WorkersLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workersArray = new Worker[4] 
            { 
                new Driver("Водитель1", 30, 12345678, "Мерседес", 400),
                new Driver("Водитель2", 46, 12312312, "Volvo", 256),
                new Manager("Менеджер1", 25, 4444444, 10),
                new Manager("Менеджер2", 31, 55555555, 8)
            };

            Worker.PrintAllWorkers(workersArray);
            Console.WriteLine();
            Console.WriteLine("Число работников: " + Worker.count);
            Console.WriteLine();

            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
