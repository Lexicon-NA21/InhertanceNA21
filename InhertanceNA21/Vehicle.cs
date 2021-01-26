using System;
using System.Collections.Generic;
using System.Text;

namespace InhertanceNA21
{

    //Interface
    //En klass kan implementera (ärva) från många interface
    //Allt är publikt
    //Måste Implementeras i ärvda klasser
    //(Kan ha implementation from c# 8)
    //Kan inte implementeras - ej skapa objekt av med new
    public interface IDrive
    {
        string Drive(double distance);
    }

    //Abstrakt
    //Kan inte implementeras - ej skapa objekt av med new
    //Kan inehålla en blandnig av vanliga metoder och abstrakta metoder utan implementation
    //Alla abstrakta medlemmar måste implemneteras av dem som ärver från den abstrakta klassen
    //Kan hålla privata fält
    abstract class AbstractVehicle : IDrive
    {
        //Virtual - En metod som markeras med nykelordet virtual är ok att skriva en ny implementation i  ärvda klasser
        public virtual string Drive(double distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance} km";
        }

        //Håller ingen implementation måste implementeras i ärvda klasser
        public abstract string Turn();
    }

    //Vehicle ärver från AbstractVehicle
    class Vehicle : AbstractVehicle
    {
        protected string protektedString;
        public string Brand { get; set; }
        public string RegNo { get; set; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        //Overide egen implementation av Turn
        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

     class FuelVehicle : Vehicle
    {
        //Fält
        private double fuelLevel;

        //Properties
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

        //Konstruktor
        public FuelVehicle(string brand, double fuelCapacity, string regNo) :base(brand, regNo)
        {
            FuelCapacity = fuelCapacity;
        }

        //Metoder

       
    }

    class FuelCar : FuelVehicle
    {
        //Const måste tilldelas värde kan inte ändras
        private const double fuelConsumption = 0.5;
        public double MaxDistance => FuelLevel / fuelConsumption;

        //Kedjade konstruktorer. base anropar basklassens konstruktor, this anropar den andra konstruktorn
        public FuelCar(string brand, double fuelCapacity, string regNo) : base(brand, fuelCapacity, regNo)
        {
        }

        public FuelCar() : this("DefaultName", 100, "ABC123")
        {

        }

        public  override string Drive(double distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine("Negative distance is assumed to be 0");
            }

           // FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNo : {RegNo} drove {distance}km");

            return result.ToString();
        }

        public string Sound() => "Tut Tut";



    }

    class Bicycle : AbstractVehicle
    {
        public string FrameNumber { get;  }

        public Bicycle(string frameNumber)
        {
            FrameNumber = frameNumber;
        }

        public override string Turn()
        {
            return "Bicycle turns";
        }

        public override string Drive(double distance)
        {
            return "Bicycle starts pedaling";
        }
    }



}
