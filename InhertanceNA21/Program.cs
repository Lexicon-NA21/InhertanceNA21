using System;
using System.Collections.Generic;

namespace InhertanceNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelVehicle fuelVehicle = new FuelVehicle("Volvo", 100, "ABC123");
            Vehicle vehicle = new Vehicle("Volvo", "ABC123");
            Vehicle vehicle2 = new FuelVehicle("Volvo", 100,  "ABC123");

            fuelVehicle.FuelLevel = 50;
            double level = fuelVehicle.FuelLevel;

            List<IDrive> vehicles = new List<IDrive>();
            vehicles.Add(fuelVehicle);
            vehicles.Add(vehicle);
            vehicles.Add(vehicle2);

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Drive(23));
               // Console.WriteLine(v.Turn());
            }
            
        }
    }
}
