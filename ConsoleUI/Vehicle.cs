using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle() { }


        public string Year { get; set; } = "1990";
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Maxima";




      



        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving virtually!");
        }



    }
}
