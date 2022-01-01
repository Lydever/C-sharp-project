using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的继承_1汽车类
{
    class SmallTruck
    {
        public virtual void smallTruckRun()
        {
            Console.WriteLine(" 以下是微型卡车对象的调用方法");
        }
    }
    class small1 : SmallTruck
    {
       public override void smallTruckRun()
        {
            Console.WriteLine("汽车在行驶!");
        }
    }
    class small2: SmallTruck
    {
        public  override void smallTruckRun()
        {
            Console.WriteLine("卡车在行驶!");
        }
    }
    class small3 : SmallTruck
    {
       public  override void smallTruckRun()
        {
            Console.WriteLine("微型卡车在行驶!");
        }
    }
}