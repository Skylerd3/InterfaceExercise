using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}
        public int NumOfSeats { get; set; } = 7;
        public int MilsPerGallon { get; set; } = 40;

        public int Year { get; set; } = 2025;
        public string Make { get; set; } = "Audi";
        public string Model { get; set; } = "Q3";
        public int NumOfWheels { get; set; } = 4;
        public string CompanyName { get; set; } = "AUDI";
        public string Logo { get; set; } = "AUDI CARS";


        public void CanTow()
        {
            Console.WriteLine($"The {GetType().Name} is good at towing!");
        }
        public void GoodGasMilage()
        {
            Console.WriteLine($"The {GetType().Name} gets great gas milage with {MilsPerGallon} miles per gallon.");
        }
        public void HasRoom()
        {
            Console.WriteLine($"The {GetType().Name} has pleanty of room with its {NumOfSeats} seats!");
        }
    }
}


