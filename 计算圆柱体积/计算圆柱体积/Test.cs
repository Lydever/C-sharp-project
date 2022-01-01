using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算圆柱体积
{
    class Test
    {
             int height;
        int r;
        double t;

        public int R
        {
            get 
            {
                return r;
            }

            set {
                if (value < 0)
                    Console.WriteLine("半径的值不能为负数!");
                else
                    r = value;
            }

            public int Height
            {
              get 
              {
                return height;
              }
                set
                {
                  if(value<0)
                      Console.WriteLine("高的值不能为负数!");
                  else
                  {
                    height=value;
                  }
                
                public double S
                {
                 get 
                 {
                  return 3.14*R*height;
                 }

               public Program(){}
               public Program(int x,int y){
                R=x;
                height=y;
                  }
                }
            }
        }
    }
}
