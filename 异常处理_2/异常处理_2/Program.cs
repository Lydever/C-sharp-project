using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 异常处理_2
{
class AException: ApplicationException// 声明自定义异常类AException
{
public AException(string message) // 继承的基类的构造方法
: base(message)
{ }
}

class B
{
public static int f(int x, int y)
{
if(x>100||y>100)
throw (new AException("x 或y 的数值超出100 ！")); // 抛出异常
else
return (x*y);
}

public static void Main()
{
int q;
try
{ q=f(99,56);
Console.WriteLine("99 和56 积为：{0}",q);
q=f(101,4); // 引发自定义类型的异常
Console.WriteLine (" 这行是不会被执行的。"); }
catch (AException e) // 捕捉自定义的异常
{
Console.WriteLine(" 引发自定义的异常！{0}", e.Message);
}
finally
{
Console.WriteLine("finally 始终会被执行！");
Console.Read();
} } }}
    
