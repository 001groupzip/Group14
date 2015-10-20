using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("А мне захотелось");
                Work work = new Work();
                work.DoSmth();
                Console.WriteLine(5.0/0);
            }
            catch
            {
                Console.WriteLine("Приложение не может выполнить свою задачу. Обратитесь к системному админисратору.");
            }
            finally
            {
                //действия, которые выполнятся в любом случае
            }
            
        }
    }

    class Work
    {
        public void DoSmth()
        {
            Console.WriteLine("Введите число:");
            while (true)
            {
                try
                {
                    int number;
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Pow(number, 2));
                    return;
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine(ex1.Message);
                    Console.WriteLine("Вводить надо было число!");
                    Console.WriteLine("Попробуйте еще раз:");
                }
                catch (OverflowException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    Console.WriteLine("Введите что-нибудь поменьше:");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Вводить надо было число!");
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
            
        }
    }
}
