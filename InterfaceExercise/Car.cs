using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{

        }

        public bool HasTrunk { get; set; } = true;
        public bool Convertable { get; set; } = true;

        public string CompanyName { get; set; } = "FORD";
        public string Logo { get; set; } = "FORD";
        public int Year { get; set; } = 2025;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int NumOfWheels { get; set; } = 4;



        public void CanTow()
        {
            Console.WriteLine($"The {GetType().Name} can not tow very well because its to small.");
        }
        public void GoodGasMilage()
        {
            Console.WriteLine($"The {GetType().Name} Gets good gas milage because its light in weight.");
        }
        public void HasRoom()
        {
            Console.WriteLine($"The {GetType().Name} has some room but not very much!");
        }
    }
}





