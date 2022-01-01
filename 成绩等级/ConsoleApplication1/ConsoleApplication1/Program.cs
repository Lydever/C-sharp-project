using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("请输入1-100之间的成绩值:");
            score = int.Parse(Console.ReadLine());
            string grade = "";
            if (score >= 90)
                grade = "优秀";
            else if (score >= 80)
                grade = "良好";
            else if (score >= 70)
                grade = "中等";
            else if (score >= 60)
                grade = "及格";
            else
                grade = "不及格";
            Console.WriteLine("对应的成绩等级是:{0}",grade);
            Console.ReadLine();
        }
    }
}
