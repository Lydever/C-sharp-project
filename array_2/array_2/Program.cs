using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,k;
            int[] array = new int[10];
            Random randObj = new Random();
            for(i=array.GetLowerBound(0);i<=array.GetUpperBound(0);i++){
                k = randObj.Next(10, 99);//返回一个10 ～99 的正整数
            array.SetValue(k, i);//给数组赋值
            }
            Console.Write("随机数序:");
            for (i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)                     Console.Write("{0}:",array.GetValue(i));
            Console.WriteLine();
            Array.Sort(array);
            Console.Write("排序数序:");
            for (i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine(); 

        }
    }
}
