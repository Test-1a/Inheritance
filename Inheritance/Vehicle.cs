using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface IVehicle
    {
        string RegNo { get; set; }

        string Drive(double distanceKm);
    }

    class Vehicle : IVehicle
    {
        //public Vehicle(string regNo = "AAA111") //using OPTIONAL (DEFAULT) VALUE
        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }

        public string RegNo { get; set; }

        public virtual string Drive(double distanceKm)     //virtual -> now we can do override
        {
            return $"Vehicle wants to drive for {distanceKm} km";
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle(string frameNumber) : base(frameNumber)   //anropar Vehicle's konstructor
        {

        }

        public override string Drive(double distanceKm)
        {
            //base.Drive();
            return $"{base.Drive(distanceKm)}, Bicycle starts pedaling for {distanceKm} km";
        }

    }


    class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel
        {
            get
            {
                return FuelLevel;
            }

            set
            {
                double newLevel = Math.Max(0, value);   //Kan inte sätta mindre än 0 liter
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            }
        }

        public double FuelCapacity { get; }

        public FuelVehicle(string regNo, double fuelCapacity) : base(regNo)   //anropar Vehicles konstruktor
        {
            FuelCapacity = fuelCapacity;
        }
    }


    class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;

        public double Milage { get; set; }
        public FuelCar(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {

        }

        public override string Drive(double distanceKm)
        {
            var resultBuilder = new StringBuilder();

            resultBuilder.AppendLine(base.Drive(distanceKm));

            if (distanceKm < 0)
            {
                distanceKm = 0;
                resultBuilder.AppendLine($"Negative distance is assumed to be 0");
            }

            double maxDistance = FuelLevel / fuelConsumption;

            if (distanceKm > maxDistance)
            {
                distanceKm = maxDistance;
                resultBuilder.AppendLine("\nNot enough fuel!");
            }

            FuelLevel -= distanceKm * fuelConsumption;
            Milage += distanceKm;

            resultBuilder.AppendLine($"\nRegNo: {RegNo} drove {distanceKm}km");

            return resultBuilder.ToString(); 
        }


    }
}
