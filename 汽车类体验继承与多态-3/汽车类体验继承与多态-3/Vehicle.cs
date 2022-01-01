using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 汽车类体验继承与多态_3
{
    public class Vehicle
    {
        public virtual void vehicleRun()
        {
            Console.WriteLine("汽车在行驶!");
        }
    }

    public class Truck:Vehicle
    {
        public override void vehicleRun()
        {
            Console.WriteLine(" 卡车在行驶!");
        }
    }

    public class SmallTruck : Vehicle
    {
        public override void vehicleRun()
        {
            Console.WriteLine("微型卡车在行驶!");
        }
    }
}
