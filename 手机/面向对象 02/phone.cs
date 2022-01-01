using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象_02
{
    class phone
    {
        public string 品牌;
        public string 型号;
        public string 颜色;
        public decimal 价格;
        public void show(string brand,string model,string color,decimal price) 
        {
            this.品牌 = brand;
            this.型号 = model;
            this.颜色 =color;
            this.价格 = price;
            Console.WriteLine("您选择的手机信息如下:");
            Console.WriteLine("手机品牌: " +this.品牌);
            Console.WriteLine("手机型号: "+this.型号);
            Console.WriteLine(" 手机颜色: "+this.颜色);
            Console.WriteLine("手机价格：" + this.价格);
            Console.WriteLine("谢谢您的参与！");
            Console.ReadKey();
        }
    }
}
