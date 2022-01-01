using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 请输入品牌名称:NOKIA, MOTO,Lenovo");
            string input = Console.ReadLine();
            phone Mobile = new phone();
            switch (input) { 
                case "NOKIA":
                    Mobile.show("NOKIA", "N98", "黑色", 4999);
                    break;
                case "MOTO":
                    Mobile.show("MOTO", "MOTO ME525", "红色", 1989);
                    break;
                case "Lenovo":
                    Mobile.show("联想", "联想E268翻盖手机", "珍珠白", 1399);
                    break;
                default:
                    Console.WriteLine(" 请输入正确的手机品牌!");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
