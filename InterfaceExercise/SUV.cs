using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
        public string LegRoom { get; set; } = "exellent leg room";
        public string SeatCount { get; set; } = "7 count seating";

        //from interface
        public string Model { get; set; } = "Mini Van";
        public string Make { get; set; } = "Buick";
        public string Color { get; set; } = "Midnight blue";
        public double Drivetrain { get; set; } = 2.3;
        public string BizName { get; set; } = "Bee's Auto";
        public string Address { get; set; } = "123 Grove Street";

        public SUV()
		{
            Console.WriteLine();
		}


        public void DisplayDetails()
        {
            Console.WriteLine($"For Sale at {BizName}: {Make} {Model} The color is {Color}. It has {LegRoom} and has {SeatCount}.");
        }




    }
}

