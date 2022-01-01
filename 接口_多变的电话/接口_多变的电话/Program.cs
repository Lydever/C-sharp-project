using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口_多变的电话
{
    public interface IPhone
    {
        void getPhoneNumber();
        void getRingTone();
    }
    public interface IPhoneDetails
    {
        void getMfgModel();
    }
    public class MyPhone : IPhone, IPhoneDetails
    {
        public void getPhoneNumber()
        {
            Console.WriteLine("显示电话号码");
        }
        public void getRingTone()
        { 
            Console.WriteLine("显示来电铃声");
        }
        public void getMfgModel()
        {
            Console.WriteLine("显示电话制造商和型号");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyPhone objP = new MyPhone();
            objP.getPhoneNumber();
            objP.getRingTone();
            objP.getMfgModel();
            Console.ReadKey();
        }
    }
}
