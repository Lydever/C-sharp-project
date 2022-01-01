using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.CSharp;

namespace 项目7_抽象类和接口输出职员薪水
{
    //programmer
    class Programmer
    {
        public class Programmer : Employee, IPromotable
        {
            protected double hours;
            public Programmer() { }
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
    //shixi
    class Shixi
    {
        public class Shixi : Employee
        {
            private double salary;
            protected int months;
            private string name;
            public Shixi() { }
            public Shixi(string name, double salary, int months)
            {
                this.Name = name;
                this.Salary = salary;
                this.Months = months;
            }
            public override void Print()
            {
                Console.WriteLine("实习生");
                Console.WriteLine("姓名:" + this.Name);
                Console.WriteLine("薪水:" + this.Salary);
                Console.WriteLine("实习期:" + this.Months);
            }

            public string Name
            {
                get { return name; }
                set { value = name; }
            }
            public double Salary
            {
                get { return salary; }
                set
                {
                    if (value > 0)
                        value = salary;
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
    //manager
    class Manager
    {
        private string mishu;
        public class Manager : Employee, Programmer, IPromotable.IGoodWorkes
        {
            public Manager() { }
            public Manager(string name, double salary, string mishu)
            {
                this.Name = name;
                this.Salary = salary;
                this.Mishu = mishu;
            }
            public override void print()
            {
                Console.WriteLine("经理");
                Console.WriteLine("姓名:" + this.Name);
                Console.WriteLine("薪水:" + this.Salary);
                Console.WriteLine("秘书:" + this.Mishu);
            }

            public string Mishu
            {
                get { return mishu; }
                set { mishu = value; }
            }

            public abstract string Print();
            public abstract string IGoodWorker();
            public abstract string IPromotable();
            public abstract string Manager();
            void IPromotable.Promote()
            {
                Console.WriteLine("加班后的薪水:" + this.Salary);
            }
            void IGoodWorke.Promote()
            {
                Console.WriteLine("经理是优秀的的,所以获得职位的晋升");
            }
        }
    }
    //ipromotes
    class IPromotes
    {
        public interface IPromotable
        {
            void Promote();
        }
    }
    //IGoodWorker
    class IGoodWorker
    {
        public interface myIGoodWorker
        {
            void Promote();
        }
    }
    //Employee
    class Employee
    {
        public abstract class Employee   //创建Employee类
        {
            public Employee() { }  //构造函数声明
            public Employee(string name, double salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
            //私有字段
            private string name;
            private double salary;
            //公有属性
            public string Name
            {
                get { return name; }
                set { value = name; }
            }
            public double Salary
            {
                get { return salary; }
                set
                {
                    if (value > 0)
                        value = salary;
                    else
                        salary = 1;
                }
            }
            //声明抽象方法
            public abstract string Employee();
            public abstract void Print();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shixi sx = new Shixi("赵丰",5500,2);
            sx.print();
            Console.WriteLine();

            Programmer programmer = new Programmer();
            programmer.print();
            IPromote promote = programmer;
            promote.Promote();
            Console.WriteLine();

            Manager manager = new Manager("约翰",12000,"玛丽");
            manager.print();
            IPromote promotable1 = manager;
           myIGoodWorker goodworker = manager;
            promotable1.Promote();
            goodworker.Promote();
        }
    }
}
