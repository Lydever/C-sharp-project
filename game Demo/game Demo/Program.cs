using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace game_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int radNum;
            Random rad = new Random();
            radNum = rad.Next(1,100);
            Console.Write("请输入您要输入的次数:");
            int a = int.Parse(Console.ReadLine());
            int b;
            for (int i = a; a > 0; a--)
            {
                Console.Write(" 请输入一个数字:");
                b = int.Parse(Console.ReadLine());
                if (b == radNum)
                {
                    Console.Write("恭喜你正确");
                    break;
                }
                else if (b > radNum)
                    Console.WriteLine("你输入的数字大了!");
                    else
                    Console.WriteLine("你输入的数字小了!");
                }
            if (a == 0)
                Console.WriteLine("很遗憾次数已用完!");
              Console.ReadLine();
        }
    }
}
