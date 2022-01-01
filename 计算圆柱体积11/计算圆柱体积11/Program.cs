using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算圆柱体积11
{
    class Program
    {
        //定义成员
        int r;
        int h;

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("半径的值不能为负数！");
                else
                    r = value;
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
                if (value < 0)
                    Console.WriteLine("高的值不能为负数！");
                else
                    h = value;
            }
        }


        public double S
        {
            get
            {
                return 3.14 * R * H;
             }
        }

        public Program(){}

        public Program(int a, int b)
        {
            R = a;
            H = b;
        }


        static void Main(string[] args)
        {
            Program demo = new Program();
            demo.R = 5;
            demo.H = 20;
            Console.WriteLine("半径:{0},高{1}:,体积={2}", demo.R, demo.H, demo.S);
            demo.R = -10;
            demo.H = 20;
            Console.WriteLine("半径:{0},高{1}:,体积={2}", demo.R, demo.H, demo.S);
            demo.R = 10;
            demo.H = -20;
            Console.WriteLine("半径:{0},高{1}:,体积={2}", demo.R, demo.H, demo.S);
            Console.ReadKey();
        }
    }
}
