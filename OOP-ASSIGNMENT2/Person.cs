using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT2
{
    public class Person
    {
        private int id;
        private string name;
        private string email;

        public Person(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
        public int getId() => id;
        public string getName() => name;
        public string getEmail() => email;

    }
}
