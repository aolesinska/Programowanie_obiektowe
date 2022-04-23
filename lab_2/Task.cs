using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
        class Task
        {
            public string name;
            public TaskStatus status;

            public string Name { get => this.name; }
            public TaskStatus Status { get => this.status; }

            public Task(string name, TaskStatus status)
            {
                this.name = name;
                this.status = status;
            }

            public bool Equals(Task other)
            {
                if (other == null) return false;
                if (other == this) return true;

                return Object.Equals(other.name, this.name) && Object.Equals(other.status, this.status);
            }

            public override string ToString()
            {
                return $"{Name} [{Status}]";
            }
        }
    
    
}
enum TaskStatus
{
    Waiting,
    Progress,
    Done,
    Rejected
}
