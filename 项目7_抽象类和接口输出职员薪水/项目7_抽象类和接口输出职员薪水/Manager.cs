using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 项目7_抽象类和接口输出职员薪水
{
    class Manager
    {
        private string mishu;
        public class Manager : Employee,Programmer,IPromotable.IGoodWorkes
        {
            public Manager() { }
            public Manager(string name,double salary,string mishu)
            {
                this.Name = name;
                this.Salary = salary;
                this.Mishu= mishu;
            }
            public override void print()
            {
                Console.WriteLine("经理");
                Console.WriteLine("姓名:"+this.Name);
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
                Console.WriteLine("加班后的薪水:"+this.Salary);
            }
            void IGoodWorke.Promote()
            {
                Console.WriteLine("经理是优秀的的,所以获得职位的晋升");
            }
        }
    }
}
