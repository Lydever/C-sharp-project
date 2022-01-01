using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=3;
            while(i<=3){
            Console.WriteLine("请输入用户名:");
             String usename =Console.ReadLine();
            int a=int.Parse(Console.ReadLine());
            if (usename == "admin")
            {
                Console.WriteLine("欢迎{0}",usename+"!");
                  break;
            }
            else if (i <= 3)
            {
                Console.WriteLine("请输入用户名:");
            } 
            else{
                Console.WriteLine("输入次数超过3次!");
              return;
            }
            i--;
        }
    }
}
}