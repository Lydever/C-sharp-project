using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace this_用于构造函数声明
{
    class test   // 定义test
    {
        public test(int n)                      //声明一个关键字的构造函数
        {
            Console.WriteLine("test.test(int n)");        //声明两个关键字的构造函数
        }

        public test(string s, int n)  : this(0)
        {
            Console.WriteLine("test.test(string s,int n)");
        }
    }

    class Demo     //定义demo类
    {
        static void Main()
        {
            test a = new test("test(test class", 1); //定义实例对象
            Console.ReadKey();
        }
    }
}
