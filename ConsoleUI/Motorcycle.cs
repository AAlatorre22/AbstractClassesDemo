using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() { }

        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle drives abstract");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycles drive virtually");
        }
    }
}
