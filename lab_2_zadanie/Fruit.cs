using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Fruit : Product
    {
        private int count;
        public int Count
        {
            get => this.count;
            set => count = value;
        }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }

        public override void Print(string prefix)
        {
            string[] temp = { "fruit", "fruits" };
            Console.WriteLine(prefix + $"{this.Name} ({this.count} " +
                $"{(this.count > 1 ? temp[0] : temp[1])}" + $")");
        }
    }
}
