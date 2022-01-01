using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 项目7_抽象类和接口输出职员薪水
{
    class Employee
    {
        public abstract class Employee   //创建Employee类
        {
            public Employee() { }  //构造函数声明
            public Employee(string name,double salary)
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
}
