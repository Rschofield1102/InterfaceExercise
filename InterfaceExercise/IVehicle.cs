using System;
namespace InterfaceExercise
{

	
	public interface IVehicle
	{
		public string Model { get; set; } 
		public string Make { get; set; }
		public string Color { get; set; }
		public double Drivetrain { get; set; }



		//create stubbed out method - then use it in deprived classes
		public void DisplayDetails();
		




	}
}

