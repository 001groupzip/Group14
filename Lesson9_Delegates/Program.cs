using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9_Delegates
{
    class Program
    {
        delegate void BinaryOp(int a, int b);
        static void Main(string[] args)
        {
            #region Объявление делегатов
            //Sum(10, 20);
            //Mul(1, 10);
            //сигнатуры методов: void (int a, int b) --> сигнатура делегата

            /*BinaryOp op = new BinaryOp(Sum);
            op += new BinaryOp(Sum);
            op += Sum;
            op += Mul;
            op(1, 10);
            Console.WriteLine(int.MaxValue);*/

            /*Action<int, int> action = Sum;
            action(10, 20);

            Func<DateTime, string> func = ToString;
            Console.WriteLine( func(DateTime.Now));*/
            
            #endregion

            Func<int, int, int> workItem = GetNumbers;
            workItem.BeginInvoke(10, 20, ShowGetNumbersResult, null);
            //c использованием Колл-Бэка
                        
            

            while (Console.ReadLine() != "exit"){ }


            BinaryOp op = new BinaryOp(Sum);
            op += Mul;
            op += Sum;

            Delegate[] ops = op.GetInvocationList();
            for (int i = 0; i < ops.Length; i++)
            {
                (ops[i] as BinaryOp).BeginInvoke(1, 10, null, null);
            }

        }

        static void ShowGetNumbersResult(IAsyncResult ires)
        {
            AsyncResult res = (AsyncResult)ires;
            Func<int, int, int> workItem = (Func<int, int, int>)res.AsyncDelegate;

            int sum = workItem.EndInvoke(ires);
            Console.WriteLine("Сумма = {0}, {1}", sum);
            return;
        }

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            return sum;
        }

        static string ToString(DateTime time)
        {
            return time.ToLongTimeString();
        }

        static void Sum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
                sum += i;
            Console.WriteLine(sum);
        }

        static void Mul(int a, int b)
        {
            int mul = 1;
            for (int i = a; i <= b; i++)
                mul *= i;
            Console.WriteLine(mul);
        }
    }
}
