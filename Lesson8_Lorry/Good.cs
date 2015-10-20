using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    abstract class Good
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract void Print();
    }
}
