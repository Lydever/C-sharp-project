using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiekou_cxlei
{
    //定义一个Employee抽象类
    public abstract class Employee
    {
        protected String Name;         //属性
        protected double salary;
        abstract public void print();     //print()抽象方法
    }
    public interface IPromotable      //定义IPromotable接口
    {
        void Promote();
    }

    public interface IGoodWorker       //定义IGoodWorker 接口
    {
        void Promote();
    }
    public class Shixi : Employee       //派生类Shixi类继承Employee基类
    {
        protected int months;
        public Shixi() { }
        public Shixi(String Name, double salary, int months)
        {
            this.Name = Name;
            this.salary = salary;
            this.months = months;
        }
        public override void print()    //重写print()方法
        {
            Console.WriteLine("实习生:");
            Console.WriteLine("姓名:" + this.Name);
            Console.WriteLine("薪水:" + this.salary);
            Console.WriteLine("实习生期:" + this.months);
        }
    }
    public class Programmer : Shixi, IPromotable  //派生类Programmer 类继承Employee基类  接口IPromotable
    {
        protected int hours;
        public Programmer() { }
        public Programmer(String Name, double salary, int hours)
        {
            this.Name = Name;
            this.salary = salary;
            this.hours = hours;
        }
        public override void print()
        {
            Console.WriteLine("程序员:");
            Console.WriteLine("姓名:" + this.Name);
            Console.WriteLine("薪水:" + this.salary);
            Console.WriteLine("平均加班时间:" + this.hours);
        }
        public void Promote()
        {
            salary *= 1.5f;
            Console.WriteLine("加薪后的薪水:" + this.salary);
        }
    }
    public class Manager : Programmer, IPromotable, IGoodWorker  //派生类Manager 类继承Employee基类  接口IPromotable, IGoodWorker
    {
        protected String mishu;
        public Manager() { }
        public Manager(String Name, double salary, String mishu)
        {
            this.Name = Name;
            this.salary = salary;
            this.mishu = mishu;
        }
        public override void print()
        {
            Console.WriteLine("经理:");
            Console.WriteLine("姓名:" + this.Name);
            Console.WriteLine("薪水:" + this.salary);
            Console.WriteLine("秘书:" + this.mishu);
        }
        void IPromotable.Promote()        //实例化Promote()
        {
            salary *= 1.8f;
            Console.WriteLine("加薪后的薪水:" + this.salary);
        }
        void IGoodWorker.Promote()
        {
            Console.WriteLine("经理是优秀的,所以获得职位的晋升");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Shixi sx = new Shixi("赵丰", 5500, 2);
                sx.print();
                Console.WriteLine();

                Programmer programmer = new Programmer("张强", 45000, 4);
                programmer.print();
                IPromotable promotable = programmer;
                promotable.Promote();
                Console.WriteLine();

                Manager manager = new Manager("约翰", 120000, "玛丽");
                manager.print();
                IPromotable promotable2 = manager;
                IGoodWorker goodworker = manager;
                promotable.Promote();
                goodworker.Promote();
                Console.ReadKey();
            }
        }
    }
}