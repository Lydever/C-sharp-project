using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的继承_1汽车类
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomobileObject ao;
            ao = new AutomobileObject();
            ao.Automobile();
            ao = new vehicleRun();
            ao.Automobile();
            ao = new truckRun();
            ao.Automobile();

            SmallTruck st;
            st = new SmallTruck();
            st.smallTruckRun();
            st = new small1();
            st.smallTruckRun();
            st = new small2();
            st.smallTruckRun();
            st = new small3();
            st.smallTruckRun();

            Console.ReadKey();
        }
    }
}
