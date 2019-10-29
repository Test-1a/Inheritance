using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //FGH
            IVehicle vehicle = new Vehicle("ABC123");
            IVehicle bike = new Bicycle("BBB333zGH45");
            IVehicle fuelVehicle = new FuelVehicle("AAA444", 100)   //skickar regnummer o fuelcapacity till constr
            {
                FuelLevel = 50
            };


            Console.WriteLine(vehicle.Drive(150));
            Console.WriteLine("------------------");
            var result = bike.Drive(8);
            Console.WriteLine(result);
            Console.WriteLine("------------------");

            Class1 classobj = new Class3()
            {
                Name = "Kalle",
                Age = 12,
                Adress = "Blahavägen 3"
            };

            FuelCar fuelCar = new FuelCar("FFF777", 150)
            {
                FuelLevel = 50
            };

            Console.WriteLine(fuelCar.Milage);
            Console.WriteLine(fuelCar.Drive(20));
            Console.WriteLine(fuelCar.Drive(40));
            Console.WriteLine(fuelCar.Milage);
        }
    }
}
