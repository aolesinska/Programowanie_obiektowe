using System;
using System.Collections.Generic;

namespace lab_2
{
    class Classroom
    {
        private string name;
        private Person[] persons;

        public Person[] Persons { get => this.persons; }

        public Classroom(string name, Person[] person)
        {
            this.name = name;
            this.persons = person;
        }

        public void displayPersons()
        {
            foreach (var p in persons)
            {
                Console.Write(p);
            }
        }

        public override string ToString()
        {
            string result = "";
            result += $"Classroom: {this.name}\n\n";
            for (int i = 0; i < persons.Length; i++)
            {
                result += persons[i].ToString();
            }
            return result;
        }
    }
}