using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 汽车品牌信息
{
    class 汽车
    {
        public string 品牌;
        public string 型号;
        public string 颜色;
        public decimal 价格;

        public void show(string brand, string model,string color,decimal price ) {
            this.品牌 = brand;
            this.型号 = model;
            this.颜色 = color;
            this.价格 = price;
            Console.WriteLine("您选择的轿车信息如下：");
            Console.WriteLine("轿车品牌：" + this.品牌);
            Console.WriteLine("轿车型号：" + this.型号);
            Console.WriteLine("轿车颜色：" + this.颜色);
            Console.WriteLine("轿车价格：" + this.价格);
            Console.WriteLine("谢谢您的参与！");
            Console.ReadKey();

        }
    }
}
