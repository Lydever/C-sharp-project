using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 汽车品牌信息
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 请输入品牌名称: Mercedes, BMW, AuDi");
            string input = Console.ReadLine();
            汽车 qiChe = new 汽车();
            switch (input) { 
                case "BMW":
                    qiChe.show("宝马","X6","红色",1900000);
                    break;
                case "Mercedes":
                    qiChe.show("奔驰", "s500", "黑色", 1200000);
                    break;
                case "AuDi":
                    qiChe.show("奥迪", "A8", "黑色",399999);
                    break;
                default:
                    Console.WriteLine("请输入正确的汽车品牌名称！");
                    Console.ReadKey();
                    break; 
            }
        }
    }
}
