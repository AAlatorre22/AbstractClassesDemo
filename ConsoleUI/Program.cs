using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles




            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */


            var vehicles = new List<Vehicle>();

            var civic = new Car() { Year = "2020", Make = "Honda", Model = "Civic",  HasTrunk = true };
            var r1 = new Motorcycle() { Year = "2006", Make = "Yamaha", Model = "R1", HasSideCar = true };
            Vehicle truck = new Car() { Year = "2010", Make = "Dodge", Model = "Ram", HasTrunk = false };
            Vehicle suv = new Car() { Year = "2020", Make = "Mazda", Model = "CX-5", HasTrunk = true };

            vehicles.Add(civic);
            vehicles.Add(r1);
            vehicles.Add(truck);
            vehicles.Add(suv);
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Here we have a {vehicle.Year} {vehicle.Make} {vehicle.Model}");
               // Console.WriteLine();
                vehicle.DriveAbstract();
               // Console.WriteLine();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }
                        

                  
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
