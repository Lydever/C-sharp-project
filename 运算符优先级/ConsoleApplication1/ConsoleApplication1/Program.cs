using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count;//贷款金额.还款月数;
            float l;      //利率
            Console.Write("贷款金额:");
            x = int.Parse(Console.ReadLine());
            Console.Write("还款月数:");
            count = int.Parse(Console.ReadLine());
            Console.Write("贷款利率:");
            l = float.Parse(Console.ReadLine());

            double s;
            s = Math.Pow(1+l/12,count);
            double money;
            money = x * (l / 12) * s / (s - 1);
            Console.Write("每月需还款金额是:{0}",money);
        }
    }

}