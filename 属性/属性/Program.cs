using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Date s = new Date();
            Console.WriteLine(s.Month);
            s.Month = 10;
            Console.WriteLine(s.Month);
            Console.Read();
        }
    }
}
