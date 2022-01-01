using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace 实训8_矩阵数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[,] arr = new int[4,4]{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            //原始矩阵
            Console.Write( "原始矩阵:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j= 0; j < arr.GetLength(0); j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(arr[i,j]+"\t");
                    if (i == j || i + j == 4)
                    { 
                      sum+=arr[i,j];
                    }
                }              
            }
            Console.WriteLine();

            //上三角形矩阵





                //矩阵A转置
               
            Console.Write("矩阵A转置:");
            for (int j = 0;j< arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(arr[i, j] + "\t");
                }

            }



            Console.ReadKey();
        }
    }
}
