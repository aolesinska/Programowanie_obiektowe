using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop : IThing
    {
        private string name;
        public string Name
        {
            get => this.name;
            set => name = value;
        }
        private Person[] people;
        private Product[] products;

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine($"Shop: {this.Name}");
            Console.WriteLine("-- People: --");
            foreach (Person person in this.people)
            {
                person.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product product in this.products)
            {
                product.Print("\t");
            }
        }

    }
}
