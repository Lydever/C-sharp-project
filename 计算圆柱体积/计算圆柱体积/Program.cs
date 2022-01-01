using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算圆柱体积
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.R=5;
            a.height=20;
             Console.WriteLine("半径:{0},高:{1},体积:{2}",a.R,a.height,a.S);
              a.R=5;
            a.height=-20;
             Console.WriteLine("半径:{0},高:{1},体积:{2}",a.R,a.height,a.S);

            Program d = new Program(-10,-30);
             Console.WriteLine("半径:{0},高:{1},体积:{2}",a.R,a.height,a.S);
              Console.ReadKey();

        }
    }
}
