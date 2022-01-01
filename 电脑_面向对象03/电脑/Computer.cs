using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 电脑
{
    class Computer
    {
        public string CPU;
        public string 内存;
        public string 硬盘;
        public string 显示器;

        public void show(string cpu,string inte, string disk, string display) { 
            this.CPU = cpu;
            this.内存 = inte;
            this.硬盘 = disk;
            this.显示器 = display;
            Console.WriteLine("我的电脑配置如下:");
            Console.WriteLine("CPU:"+this.CPU);
            Console.WriteLine("内存:" + this.内存);
            Console.WriteLine("硬盘:" + this.硬盘);
            Console.WriteLine("显示器:" + this.显示器);
            Console.ReadKey();
        }

        public void inter(){
            Console.WriteLine("上网");
        }
        public void play()
        {
            Console.WriteLine("玩电脑游戏");
        }
        public void work()
        {
            Console.WriteLine("办公");
        }
    }
}
