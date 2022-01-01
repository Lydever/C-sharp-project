using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("请输入一个正整数: ");
            n= int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine(" 1到{0}之间全部的整数为:",n);
                int j = 1;
                while (j <= n) { 
                 Console.WriteLine(j.ToString());
                    j++;
                }
                Console.WriteLine();
            }
            else {
             return;
             }
         }
      }
   }