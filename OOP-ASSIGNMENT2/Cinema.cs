using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT2
{
    public class Cinema
    {
        public string Location { get; set; }
        public bool IsOpen { get; set; }

        public Cinema(string location, bool IsOpen)
        {
            Location = location;
            IsOpen = IsOpen;
           
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Cinema: {Location}, Open: {IsOpen}");
        }




    }
}
