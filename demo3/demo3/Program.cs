using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {/*实 训六：编写一个控制台应用程序，输出 1~10 的平方值。分别用 while 、 do 、 for 、 foreach*/
            /*用while实现*/
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i + "*" + i + "=" + (i * i));
                i++;               
            }
            /*用do实现*/
           int i = 1;
            do
            {
                Console.WriteLine(i + "*" + i + "=" + (i * i));
                i++;
            } while (i <= 10);
            /*用for实现*/
             int sum= 1;
                  for (int i = 1; i <= 10; i++)
                  {
                      sum = i * i;
                      Console.WriteLine(i + "*" + i + "=" + (i * i));
                  }
                  /*用foreach实现*/
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("1-10的平方值为:");
            foreach (int i in a)
                Console.WriteLine(i + "*" + i + "=" + (i * i));
        }
    }
}
