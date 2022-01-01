using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的多态性
{
    class Animal_1
    {
        public virtual void Shout()
        {
            Console.WriteLine("动物叫");
        }
    }

    class Dog : Animal_1
    {
        public override void Shout()
        {
            Console.WriteLine("我是小狗汪汪叫!");
        }
    }

    class Cat : Animal_1
    {
        public override void Shout()
        {
            Console.WriteLine("我是小猫喵喵叫!");
        }
    }


}
