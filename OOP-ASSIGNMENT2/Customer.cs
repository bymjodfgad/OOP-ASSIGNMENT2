using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT2
{
    public class Customer : Person
    {
        public int BonusPoints { get; private set; }

        public Customer(int id, string name, string email) : base(id, name, email)
        {
            BonusPoints = 0;
        }

        public void AddPoints(int points)
        {

            Console.WriteLine("add points function here");
        
        }
    }
}
