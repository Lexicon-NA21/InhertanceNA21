using System;
using System.Collections.Generic;
using System.Text;

namespace InhertanceNA21
{
    class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(double distance)
        {
           return $"{this.GetType().Name} drove for {distance} km";
        }
      

    }

    class FuelVehicle : Vehicle
    {
        public FuelVehicle(string brand) :base(brand){}

       
    }
}
