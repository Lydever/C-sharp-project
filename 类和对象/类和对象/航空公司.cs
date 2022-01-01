using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类和对象
{
    class 航空公司
    {
        public string 售票员;
        public 航空公司()
        {
            string 公司名称 = "南方航空公司";
            Console.WriteLine("构造函数已经被初始化,其作用是指明了航空公司!");
            Console.Write("公司名称: "+公司名称);
        }

        public void 机票信息()
        {
            string 航班 = "CZ6219";
            string 起飞时间 = "09:00";
            string 起飞地点 = "广州白云机场";
            string 到达时间 = "10:45";
            string 到达地点 = "北京首都机场";
            string 飞机型号 = "空客A329";
            decimal 票价 = 1000;
            string 座位号 = "经济舱";
            Console.WriteLine("航班:"+航班);
            Console.WriteLine("起飞时间:"+起飞时间);
            Console.WriteLine("起飞地点:"+起飞地点);
            Console.WriteLine("到达时间:"+到达时间);
            Console.WriteLine("飞机型号"+飞机型号);
            Console.WriteLine("票价"+票价);
            Console.WriteLine("座位号:"+座位号);
         }
    }
}
