using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 请输入第一个数字:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int max = n1 > n2 ? n1 : n2;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
