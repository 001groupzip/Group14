using System;

namespace Group14
{

    class Program
    {

        static void Main(string[] args)
        {
            /*int number;
            number = 10; //инициализация
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);
            
            int number2 = 15;
            Console.WriteLine(number2);

            number = 10 * 45151 + 46416;
            Console.WriteLine(number);

            number = 10 - number;
            Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine();

            number = 56 / 10;
            Console.WriteLine(number);

            number = 56 % 10;
            Console.WriteLine(number);
            number = 56;
            double number3 = (double)number / 10; //56.0 / 10
            Console.WriteLine(number3);*/

            /*string text = "46513";
            Console.WriteLine(text);

            int number = int.Parse(text);
            number = number + 1;
            Console.WriteLine(number);
            text = number.ToString();
            Console.WriteLine(text);

            Console.WriteLine("a"+"b"+"cарпмори46513"); //конкатенация строк (сложение строк)

            char symbol = 'A';
            Console.WriteLine(symbol);

            Console.WriteLine('a' + 'b' + 'c');
            Console.WriteLine((int)'a');
            Console.WriteLine((int)'0');

            bool flag = true;
            Console.WriteLine(flag);

            flag = (true && false) || true;
            Console.WriteLine(flag);*/

            int number = 10;
            Console.WriteLine(-number);

            number = 5;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);

            number = number + 2;
            number *= 2;
            Console.WriteLine(number);

            Console.WriteLine(!false);

            //int day = 23;
            int month = 9;
            int year = 2015;

            DateTime date = new DateTime(2015, 9, 23, 20, 16, 45);
            Console.WriteLine(date);
            Console.WriteLine(date.Day);

            int number1 = 10;
            Int32 number2 = 10;

            DayOfWeek day = DayOfWeek.Friday;
            Console.WriteLine((int)day);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("xfgfcgvj");
        }
    }
}
