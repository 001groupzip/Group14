using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One
            /*string text1 = "Simple text";
            string text2 = text1;

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine();
            text1 = "123";
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine();*/
            #endregion

            #region Two
            /*string[] symbols = new string[4] { "\\", "|", "/", "-"};
            for (int i = 0; i < 200; i++)
            {
                Console.Write(symbols[i%4] + "\r");
                System.Threading.Thread.Sleep(200);
            }*/
            #endregion

            #region Three
            /* //string pathBad = "C:\NewFolder\Text.txt";
            string pathGood = "C:\\\"NewFolder\"\\Text.txt";
            string pathBest = @"C:\NewFolder\Text.txt";
            Console.WriteLine(pathBest);*/
            #endregion

            #region Four
            /*string text = "простая строка";
            Console.WriteLine();
            Console.WriteLine(text.Length);
            Console.WriteLine(text[text.Length-4]);
            Console.WriteLine(text.CompareTo("Простая строка"));
            Console.WriteLine(text.Contains("стр"));
            Console.WriteLine(text.Insert(0, "Это "));
            Console.WriteLine(text.Remove(8, 3));
            Console.WriteLine(text.Replace('о','а'));
            Console.WriteLine(text.Replace("простая", "сложная"));*/
            #endregion

            #region Five
            /*string data = "12 66 626 42684,,3547,5680 91567 71245";
            string[] items = data.Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                sum += int.Parse(items[i]);
            }
            Console.WriteLine(sum);

            string login = "     username ";
            Console.WriteLine(login);
            Console.WriteLine();
            login = login.Trim();
            Console.WriteLine(login);
            Console.WriteLine("|" + login + "|");*/
            #endregion

            #region Six
            /*string temp = string.Empty;
            for (int i = 0; i < 50000; i++)
            {
                temp += i;
            }
            Console.WriteLine(temp);

            StringBuilder builder = new StringBuilder();
            int n = 1000000;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                builder.Append(i);
            }
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            Console.WriteLine(builder.MaxCapacity);*/
            #endregion

            #region Seven
            //Point p = new Point(213.341231, 157.5862732);
            //Console.WriteLine("{0:e}",p);
            //Console.WriteLine();
            //Console.WriteLine("{0:ij}", p);
            //Console.WriteLine();
            //Console.WriteLine("{0:csv}", p);
            //Console.WriteLine();
            //double price = 99.9999;
            //Console.WriteLine("Цена: " + price);
            //Console.WriteLine();
            //Console.WriteLine("Цена: {0:e}",price);
            //Console.WriteLine();
            //Console.WriteLine("Цена: {0:c}", price);
            //Console.WriteLine();
            //price = 99.11111;
            //Console.WriteLine("Цена: {0:.0000}", price);
            //Console.WriteLine();
            //Console.WriteLine("Цена: {0:.####}", price);
            //Console.WriteLine();
            #endregion

            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("{0:hh:mm}", date);
            Console.WriteLine("{0:yy.MM.dd HH:mm}", date);
            Console.WriteLine("{0:yyyy MMM dd HH:mm:ss}", date);
            Console.ReadLine();
        }
    }

    class Point : IFormattable
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            //Console.WriteLine("Координата по X: " + x );
            //Console.WriteLine("Координата по Y: " + y);

            //Console.WriteLine("Координата по X: {0}", x);
            //Console.WriteLine("Координата по Y: {0}", y);

            string message = String.Format("Координата по X: {0}\nКоордината по Y: {1}", x, y);
            Console.WriteLine(message);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format.ToLower())
            {
                case "e":
                    return String.Format("[{0:e};{1:e}]", x, y);
                case "ij":
                    return String.Format("[{0:.##}i;{1:.##}j]", x, y);
                case "csv":
                    return String.Format("{0};{1}", x, y);
                default:
                    return ToString();
            }
        }
    }
}