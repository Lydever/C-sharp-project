using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 创建自动售货机程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择商品:1=可乐 2=冰红茶 3=营养快线 4=矿泉水 5=雪碧");
            Console.Write("请输入你要购买的商品编号:");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            double price = 0;
            switch(n)
            {
                case 1:
                price=3.5;
                break;
                case 2:
                price=2.5;
                break;
                case 3:
                price=4.5;
                break;
                case 4:
                price=1.0;
                break;
                case 5:
                price=3.5;
                break;
                default:
                Console.WriteLine("商品有误!请选择1,2,3,4,5!");
                break;
            }
            price=price!=0?price:0;
            Console.WriteLine("您消费{0}元",price);
            Console.WriteLine("谢谢您的惠顾!");
            Console.ReadKey();

        }
    }
}
