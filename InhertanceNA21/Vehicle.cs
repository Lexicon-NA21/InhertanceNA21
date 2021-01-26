using System;
using System.Collections.Generic;
using System.Text;

namespace InhertanceNA21
{

    public interface IDrive
    {
        string Drive(double distance);
    }

    abstract class AbstractVehicle : IDrive
    {
        public virtual string Drive(double distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance} km";
        }

        public abstract string Turn();
    }

    class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }
        public string RegNo { get; set; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel 
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            } 
        }

        public double FuelCapacity { get; }

        public FuelVehicle(string brand, double fuelCapacity, string regNo) :base(brand, regNo)
        {
            FuelCapacity = fuelCapacity;
        }

       
    }

    class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double MaxDistance => FuelLevel / fuelConsumption;

        public FuelCar(string brand, double fuelCapacity, string regNo) : base(brand, fuelCapacity, regNo)
        {
        }

        public FuelCar() : this("DefaultName", 100, "ABC123")
        {

        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }


    }

    class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            throw new NotImplementedException();
        }
    }



}
