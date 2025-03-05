using System;
using System.Collections.Generic;
using InterfaceExercise;
namespace InterfaceExercise;

class program
{




    static void Main(string[] args)
    {



        var car = new Car();
        var truck = new Truck();
        var suv = new SUV();

        var vehicles = new List<IVehicle>() { car, truck, suv };

        foreach (var Vehicle in vehicles)
        {
            Vehicle.HasRoom();
            Vehicle.CanTow();
            Vehicle.GoodGasMilage();


        }


    }
}
