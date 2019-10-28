using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Vehicle : IVehicle
    {
        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }

        public string RegNo { get; set; }

        public virtual string Drive()     //virtual -> now we can do override
        {
           return "Vehicle starts driving";
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle(string frameNumber) :base(frameNumber)
        {

        }

        public override string Drive()
        {
            //base.Drive();
            return base.Drive() + ", Bicycle starts pedaling";
        }
       
    }
}
