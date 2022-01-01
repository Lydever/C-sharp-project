using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的继承_1汽车类
{
    class AutomobileObject
    {
        public virtual void Automobile()
        {
            Console.WriteLine(" 以下是卡车类的调用方法");
        }
    }

    class vehicleRun : AutomobileObject
    {
        public  override void Automobile()
        {
            Console.WriteLine("汽车在行驶!");
        }
    }

      class truckRun : AutomobileObject
    {
          public  override void Automobile()
        {
            Console.WriteLine("卡车在行驶!");
        }
    }


}