using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("ABC123");
            Vehicle bike = new Bicycle("BBB333");

            Console.WriteLine(vehicle.Drive());
            Console.WriteLine("------------------");
            var result = bike.Drive();
            Console.WriteLine(result);

        }
    }
}
