using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        public string BedSize { get; set; } = "6 foot bed";
        public string TwoWheelDrive { get; set; } = "two wheel drive";

        //from interface
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F150";
        public string Color { get; set; } = "white";
        public double Drivetrain { get; set; } = 6.0;
        public string BizName { get; set; } = "Bee's Auto";
        public string Address { get; set; } = "123 Grove Street";

        public Truck()
		{
            Console.WriteLine();
		}



        public void DisplayDetails()
        {
            Console.WriteLine($"For Sale at {BizName}: {Make} {Model} The color is {Color}. It has a {BedSize} and is {TwoWheelDrive}.");
        }







    }
}

