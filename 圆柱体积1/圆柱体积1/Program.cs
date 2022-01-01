using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 圆柱体积1
{
    class Program
    {
        //计算圆柱体积，定义成员
        int r;
        int h;

        //构建属性
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0) { Console.WriteLine("半径的值不能为负数！！！"); }
                else { r = value; }
            }
        }

        public int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value < 0) { Console.WriteLine("高的值不能为负数！！！"); }
                else { h = value; }
            }
        }

        public double S
        {
            get { return 3.14 * R * H; }
        }

        //默认构造方法
        public Program() { }

        //重载构造方法
        public Program(int x, int y)
        {

            R = x;
            H = y;
        }

        static void Main(string[] args)
        {
            Program a = new Program(); //实例化对象

            a.R = 5;
            a.H = 20; //调用赋值成员_01
            Console.WriteLine("半径：{0},高：{1}，体积：{2}", a.R, a.H, a.S);

            a.R = 10;
            a.H = -20; //调用赋值成员_02
            Console.WriteLine("半径：{0},高：{1}，体积：{2}", a.R, a.H, a.S);

            Program d = new Program(-10, -20); //构造方法有参调用_01
            Console.WriteLine("半径：{0},高：{1}，体积：{2}", d.R, d.H, d.S);

            Console.ReadKey();
        }
    }

}
