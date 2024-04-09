using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new 3 objects
            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            //-----Create list and call it in loop
            List<IVehicle> vehicles = new List<IVehicle>()
            {
                car1, truck1, suv1
            };
            
            foreach(IVehicle item in vehicles)
            {
                item.DisplayDetails();
                Console.WriteLine();
            }
           //----ORR just call methods
            //car1.DisplayDetails();
            //Console.WriteLine();
            //truck1.DisplayDetails();
            //Console.WriteLine();
            //suv1.DisplayDetails();





            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONEECreate 2 Interfaces called IVehicle & ICompany

            //DONEECreate 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* DONEECreate 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* DONEECreate 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* DONEECreate 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
