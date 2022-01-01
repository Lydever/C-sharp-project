using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承_1
{
    class Program
    {
        class BaseClass 
        {
            public BaseClass()
            {
                Console.WriteLine(" 基类无参数构造函数中的内容！");
            }

            public BaseClass(int x, int y)
            {
                Console.WriteLine(" 基类有参数构造函数中的内容！x+y 的值是{0}", x + y);
            }
        }

        class DerivedClass : BaseClass
        {
            public DerivedClass(int x, int y)
            {
                Console.WriteLine(" 派生类有参数构造函数中的内容！x*y 的值是{0}",x*y);
            }
        }

        static void Main(string[] args)
        {
            DerivedClass dc =new  DerivedClass(1,2);
            
        }
    }
}
