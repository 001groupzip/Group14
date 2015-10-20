using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class Program
    {
        static void Main(string[] args)
        {
            Disc disc1 = new Disc("Photoshop", 25);
            Book book1 = new Book("Война и Мир", 5000);

            CollectionLorry lorry1 = new CollectionLorry(1000);

            try 
            {
                lorry1.Add(disc1);
                lorry1.Add(book1);

                lorry1.Add(new Book("Преступление и наказание", 200));
                lorry1.Add(new Disc("Window 8.1", 50));
            }
            catch(OverflowGoodsException ex)
            {
                Console.WriteLine("Товар не может быть добавлен");
            }
            

            //lorry1.RemoveAt(1);

            for (int i = 0; i < lorry1.Count; i++)
            {
                lorry1[i].Print();
            }

            Console.WriteLine("Количество товаров = " + lorry1.Count);

            Console.WriteLine("Масса товаров = " + lorry1.Weight);
        }
    }
}
