using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace continue_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //例：输出1 1- - 10 这 10 个数之间的偶数 
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 != 0)
                {
                    i++;
                     continue;
                }
                Console.Write(i.ToString()+",");
                i++;
            }
        }
    }
}
