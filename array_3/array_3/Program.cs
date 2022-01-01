using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace array_3
{
    class Program
    {
        static void Main(string[] args)
        {
		int[,] arr3=new int[4, 4] { 
        { 1, 2, 3, 4 }, 
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 }, 
        { 13, 14, 15, 16 }
        };

        //原始矩阵为:
        Console.WriteLine("原始矩阵为:");
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(0); j++)
            {
				 Console.Write(arr3[i,j]+"\t");    
			}
			   Console.WriteLine();
		}


        //下三角矩阵
		 Console.WriteLine("下三角矩阵:");
         for (int i = 0; i < arr3.GetLength(0); i++)
         {
			for(int j=0;j<=i;j++)
            {
				 Console.Write(arr3[i,j]+"\t");
			}
			 Console.WriteLine();
		}
		 Console.WriteLine();


         //上三角矩阵
		 Console.WriteLine("上三角矩阵:");
         for (int i = 0; i < arr3.GetLength(0); i++)
         {
			for(int k=0;k<i;k++){ }
            for (int j = i; j < arr3.GetLength(0); j++)
            {
                Console.Write(arr3[i, j] + "\t ");
			}
			  Console.WriteLine();
		}
         Console.WriteLine();


           //两条对角线之和
         int sum = 0;
         sum = 1 + 6 + 11 + 16 + 4 + 7 + 10 + 13;
         Console.WriteLine("两条对角线之和为："+sum);


             //转置矩阵
             Console.Write("转置矩阵:");
            for (int i= 0; i< arr3.GetLength(0); i++)
            {
                for (int j= 0;j< arr3.GetLength(0);j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(arr3[j,i] + "\t");               
                }
            }
            Console.WriteLine();  

            Console.ReadKey();
        }
    }
}
