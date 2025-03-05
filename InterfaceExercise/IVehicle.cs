using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int NumOfWheels { get; set; }

		public void CanTow();
		public void GoodGasMilage();
		public void HasRoom();
	}
}

