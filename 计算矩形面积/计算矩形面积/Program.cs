using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算矩形面积
{
    class Program
    {
        class mm
        {
            private int width;
            protected int height;
            public int Width
            {
                get
                {
                    return width;
                }
                set
                {
                    if (value > 0)
                        width = value;
                    else
                        Console.WriteLine("宽的值不能为负数!");
                }
            }

            public int Height
            {
                get
                {
                    return height;
                }
                set
                {
                    if (value > 0)
                        height = value;
                    else
                        Console.WriteLine("高的值不能为负数!");
                }

                public int Area
                {
                 get
                 {
                  return width *height;
                 }
                    public  mm(){}

                   public mm (int x,inty)
                   {
                     Width = x;
                       Height = y;
                   }

            set
            {
           if(value>0)
            width=value;
            else
            Console.WriteLine("宽的值不能为负数!");
         }

                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
