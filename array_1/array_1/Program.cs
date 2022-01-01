using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int [] a = new int [N];
            int i, j, min, min_i, t;
            Random randObj = new Random();
            for (i = 0; i < N; i++)
                a[i] = randObj.Next(10,99);
            Console.WriteLine("排序之前");
            for (i = 0; i < N; i++)
                Console.WriteLine("{0}", a[i]);
            Console.WriteLine();
            for (i = 0; i < N - 1; i++)
            {
                min = a[i];
                min_i = i;
                for(j=i+1;j<N;j++)
                    if (min > a[i])
                    {
                        min = a[i];
                        min_i = j;
                    }
                if (min_i != i) { t = a[min_i]; a[min_i] = a[i]; a[i] = t; }
            }
            Console.WriteLine("排序之后");
            for (i = 0; i < N; i++)
                Console.Write("{0}",a[i]);
            Console.WriteLine("  ");
            Console.ReadKey();
        }
    }
}
