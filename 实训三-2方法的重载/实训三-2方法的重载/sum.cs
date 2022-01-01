using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实训三_2方法的重载
{
    class sum
    {        
       public int  s ( int a, int b)
        {//创建一个求和的方法
            return a+b;
        }
        
        public double s(double a,double b)
        {//重载方法
            return a + b;
        }

        public string  s(string a, string b)
        {
            return a + b;
        }

        public int s(int a)
        {
            int i;
            int s1=0;
            for (i = 1; i <=a; i++)
                s1+=i;
                i++;
            return s1;
        }
    }
}
