using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组与集合_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarry = { 1,2,3,4,5};
            int[] myarry2 = new int[3] { 1, 2, 3 };

            int[,] arr = new int[3,4];
            int[,] arr2 = new int[3, 4] { {1,2,3,3},{4,5,6,6},{7,8,9,9}};
            Console.WriteLine(arr2);
            Console.ReadKey();
        }
    }
}
