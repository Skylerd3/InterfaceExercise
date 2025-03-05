using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}
        public bool HasFlatBed { get; set; } = true;
        public int TowingWeight { get; set; } = 5000;

        public int Year { get; set; } = 2025;
        public string Make { get ; set; } = "Toyota";
        public string Model { get; set; } = "Tundra";
        public int NumOfWheels { get; set; } = 4;
        public string CompanyName { get; set; } = "TOYOTA";
        public string Logo { get; set; } = "TOYOTA CARS";


        public void CanTow()
        {
            Console.WriteLine($"The {GetType().Name} can tow up to {TowingWeight}!");
        }
        
        public void GoodGasMilage()
        {
            Console.WriteLine($"Unfortanitly the {GetType().Name} does not get good gas milage because its so heavy.");
        }
        public void HasRoom()
        {
            Console.WriteLine($"The {GetType().Name} has lots of room because of its flatbed.");

        }
    }
}


