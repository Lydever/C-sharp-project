using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person lizi = new Person();
            lizi._name = "李子";
            lizi._age = 3;
            lizi._gender = '女';
            lizi.CHLSS();
            Console.ReadKey();
        }
    }
}
