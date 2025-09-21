using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT2
{
    public class Employee : Person
    {

        public string role { get; set; }
        public string task { get; set; }

        public Employee(int id, string name, string email, string role) : base(id, name, email)
        {
            role = role;
            task = "";
        }

        public void AssignTask(string task)
        {
            task = task;
            Console.WriteLine("assign task function");
        }
    }
}
