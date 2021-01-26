using System;
using System.Collections.Generic;

namespace InhertanceNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelVehicle fuelVehicle = new FuelVehicle("Volvo", 100, "ABC123");
            Vehicle vehicle1 = new Vehicle("Volvo", "ABC123");
            Vehicle vehicle2 = new FuelVehicle("Volvo", 100, "ABC123");

            fuelVehicle.FuelLevel = 50;
            double level = fuelVehicle.FuelLevel;

            List<IDrive> vehicles = new List<IDrive>
            {
                fuelVehicle,
                vehicle1,
                vehicle2,
                new FuelCar(),
                new FuelCar("Saab", 100, "dad234"),
                new Bicycle("adfaf345w3")
            };

            foreach (IDrive vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(23));

                //Null om casten inte fungerar
                FuelCar abv1 = vehicle as FuelCar;

                if (abv1 != null)
                {
                    Console.WriteLine(abv1.Turn());
                }

                //?. Nullcheck
                Console.WriteLine(abv1?.Turn());


                //Är instansen vehicle en FuelCar?
                if (vehicle is FuelCar)
                {
                    //Unsafe cast Exception om den inte fungerar
                    FuelCar abV2 = (FuelCar)vehicle;
                    Console.WriteLine(abV2.Turn());
                }

                //Är instansen vehicle en FuelCar?
                //Om ja gör även en cast och tilldela resultatet tiil varibeln fuelCar
                if (vehicle is FuelCar fuelCar)
                {
                    Console.WriteLine(fuelCar.Turn());
                }

            }

        }
    }
}
