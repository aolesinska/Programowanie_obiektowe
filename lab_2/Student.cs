using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
        class Student : Person
        {
            protected string group;
            protected List<Task> tasks = new List<Task>();

            public string Group { get => this.group; }

            public Student(string name, int age, string group) : base(name, age)
            {
                this.group = group;
            }

            public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
            {
                this.group = group;
                this.tasks = tasks;
            }

            public void AddTask(string taskName, TaskStatus taskStatus)
            {
                var task = new Task(taskName, taskStatus);
                this.tasks.Add(task);
            }

            public void RemoveTask(int index)
            {
                this.tasks.RemoveAt(index);
            }

            public void UpdateTask(int index, TaskStatus taskStatus)
            {
                this.tasks[index].status = taskStatus;
            }

            private bool SequenceEqual(List<Task> a, List<Task> b)
            {
                if (a != null)
                    return a.SequenceEqual(b);
                else
                    return false;
            }

            public bool Equals(Student other)
            {
                if (other == null) return false;
                if (other == this) return true;

                return Object.Equals(other.name, this.name) && Object.Equals(other.age, this.age) && Object.Equals(this.group, other.group);
            }

            public override string ToString()
            {
                string result = "";
                result += $"\nStudent: {this.name} ({this.age} y.o.)\n";
                result += $"Group: {this.group}\n";
                result += "Tasks:\n";
                for (int i = 0; i < tasks.Count; i++)
                {
                    result += $"{"\t"}{i + 1}. {this.tasks[i]}\n";
                }
                return result;
            }
        }
    
}
