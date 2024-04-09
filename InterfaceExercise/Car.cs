using System;
namespace InterfaceExercise
{
	public class Car :IVehicle, ICompany
	{


        public bool SunRoof { get; set; } = true;
        public bool TwoDoor { get; set; } = true;

        // from interface
        public string Model { get; set; } = "Corolla";
        public string Make { get; set; } = "Toyota";
        public string Color { get; set; } = "White";
        public double Drivetrain { get; set; } = 2.3;
        public string BizName { get; set; } = "Bee's Auto";
        public string Address { get; set; } = "123 Grove Street";




        public void DisplayDetails()
        {
            Console.WriteLine($"For sale at {BizName}: {Make} {Model} The color is: {Color}. It has a {Drivetrain} motor. It has a Sun roof: {SunRoof} and coupe: {TwoDoor}.");
        }






        public Car()
		{
            
		}


       
    }
}

