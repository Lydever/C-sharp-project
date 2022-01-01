using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goto_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                goto n1;
            goto n2;
        n1:
            Console.WriteLine(a+"-"+b+"="+(a-b));
    n2:
        Console.WriteLine("bye!");
        }
    }
}
