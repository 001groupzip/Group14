using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var number = 100;
            var text = "qwerty";

            Console.WriteLine(text.Length);
            //number = "qwerty"; ошибка компиляции

            var x = GetNumber();*/

            dynamic number = 10;
            Console.WriteLine(number);

            number += 100;
            Console.WriteLine(number);

            number = "Строка";
            Console.WriteLine(number);

            number = number + 10;
            Console.WriteLine(number);

        }
        static double GetNumber()
        {
            return 300.655131;
        }
    }
}
