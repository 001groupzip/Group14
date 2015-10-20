using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class Lorry
    {
        public Good this[int i]
        {
            get { return items[i]; }
        }

        private int maxWeight;

        public int MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        private int count;

        public int Count
        {
            get { return items.Count; }
            set { count = value; }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        private List<Good> items;

        public Lorry(int maxWeight)
        {
            this.MaxWeight = maxWeight;
            items = new List<Good>();
        }

        public void Add(Good good)
        {
            if (good.Weight + Weight > MaxWeight)
            {
                Console.WriteLine("Невозможно добавить данный товар: ");
                good.Print();
                Console.WriteLine();
                return;
            }
            items.Add(good);
            Weight += good.Weight;
        }

        public void RemoveAt(int index)
        {
            if ( index >= 0 && index < Count)
            {
                Weight -= items[index].Weight;
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Товара с таким индексом нет.");
            }
        }

    }
}
