using System;
using System.Collections.Generic;

namespace InhertanceNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelVehicle fuelVehicle = new FuelVehicle("Volvo");
            Vehicle vehicle = new Vehicle("Volvo");
            Vehicle vehicle2 = new FuelVehicle("Volvo");

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(fuelVehicle);
            vehicles.Add(vehicle);
            vehicles.Add(vehicle2);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.Drive(23));
            }
            
        }
    }
}
