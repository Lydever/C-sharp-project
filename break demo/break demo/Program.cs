using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace break_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            while (i < 10)
            {
                if (i >= 0)
                {
                    Console.WriteLine("{0}", i);
                    i--;
                }
                else {
                    break;
                }
             }
        }
    }
}
