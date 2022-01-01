using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 项目7_抽象类和接口输出职员薪水
{
    class Shixi
    {
        public class Shixi : Employee
        {
            private double salary;
            protected int months;
            private string name;
            public Shixi() { }
            public Shixi(string name,double salary,int months)
            {
                this.Name = name;
                this.Salary = salary;
                this.Months = months;
            }
            public override void Print()
            {
                Console.WriteLine("实习生");
                Console.WriteLine("姓名:"+this.Name);
                Console.WriteLine("薪水:"+this.Salary);
                Console.WriteLine("实习期:"+this.Months);
            }

            public string Name
            {
                get { return name; }
                set { value= name; }
            }
            public double Salary
            {
                get { return salary; }
                set
                {
                    if (value > 0)
                        value=salary;
                    else
                        salary = 1;
                }
            }
            public int Months
            {
                get { return months; }
                set
                {
                    if (value > 0) months = value;
                    else
                        months = 1;
                }
            }

            public abstract string Print();
            public abstract string Shixi();

        }
    }
}
