using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 项目7_抽象类和接口输出职员薪水
{
    class Programmer
    {
        public class  Programmer:Employee,IPromotable
        {
            protected double hours;
            public  Programmer() { }
            public Programmer(string name, double salary, double hours)
            {
                this.Name = name;
                this.Salary = salary;
                this.Hours = hours;
            }

            public override void Print()
            {
                Console.WriteLine("程序员");
                Console.WriteLine("姓名:" + this.Name);
                Console.WriteLine("薪水:" + this.Salary);
                Console.WriteLine("加班时间:" + this.hours);
            }
            public double Hours
            {
                get { return hours; }
                set
                {
                    if (value > 0) hours = value;
                    else
                        hours = 1;
                }
            }

            public abstract string Print();
            public abstract string Programmer();
            public abstract string Promote();

            public void Promote()
            {
                Console.WriteLine("加班后的薪水:" + this.Salary);
            }

        }
    }
}
