using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class Book : Good
    {
        public Book(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override void Print()
        {
            Console.WriteLine("Книга - '{0}'  ({1})", Name, Weight);
        }
    }
}
