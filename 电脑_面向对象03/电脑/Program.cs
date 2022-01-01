using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 电脑
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();
            myComputer.show("T2350","2G","120G","15存");
            Console.WriteLine("我用电脑做什么?");
            Console.WriteLine(" ");
            myComputer.inter();
            myComputer.play();
            myComputer.work();
            Console.ReadKey();

        }
    }
}
