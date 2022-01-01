using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实训三_2方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,z;
            double c, d;
            string e, f;
            //创建方法的实例化
            sum text = new sum();
            Console.WriteLine("请输入两个整数");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("两个整数的和为:{0}+{1}={2}",a,b,text.s(a,b));
           Console.WriteLine("");

           Console.WriteLine("请输入两个小数");
           c = Convert.ToDouble(Console.ReadLine());
           d = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("两个小数的和为:{0}+{1}={2}", c, d, text.s(c, d));
           Console.WriteLine("");

           Console.WriteLine("请输入两个字符串");
           e = Console.ReadLine();
           f = Console.ReadLine();
           Console.WriteLine("两个字符串的拼接结果为:{0}+{1}={2}", e, f, text.s(e, f));
           Console.WriteLine("");

           Console.WriteLine("请输入一个整数");
           z = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("1到100的和为:{0}",text.s(z));
           Console.ReadKey();
        }
    }
}
