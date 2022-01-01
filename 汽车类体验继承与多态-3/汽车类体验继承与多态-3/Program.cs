using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 汽车类体验继承与多态_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle;
            vehicle = new Vehicle();
            vehicle.vehicleRun();
            vehicle = new Truck();
            vehicle.vehicleRun();
            vehicle = new SmallTruck();
            vehicle.vehicleRun();
            Console.ReadKey();
        }
    }
}
