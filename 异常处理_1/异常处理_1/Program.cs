using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 异常处理_1
{
   class Program
{
}

static void Main(string[] args)
{
int x, y,z; // 定义变量
z = 0;
try // 检查是否有异常
{ Console.WriteLine(" 请输入x 的值：");
x = int.Parse(Console.ReadLine());// 接收从键盘输入的x 的值
Console.WriteLine(" 请输入y 的值：");
y = int.Parse(Console.ReadLine());// 接收从键盘输入的y 的值
z = x / y;
Console.WriteLine("z 的值为：" +z); }
catch (DivideByZeroException ex) // 获取除数为0 的异常
{ Console.WriteLine(" 除数不能为0 ，你知道吗?" + ex.Message); }
Console.ReadKey();
}
}

