using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace break_Continue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; i += 2) {
                sum += i;
            }
            Console.WriteLine("1+3+5+...+99={0}",sum);
        }
    }
}
