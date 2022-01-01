using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象类与方法1
{
    abstract class Animal     //声明Animal抽象基类
    {
        public abstract void Shout();   //抽象方法
        public void Walk()               //非抽象方法
        {
            Console.WriteLine("动物走路!");
        }
    }

    class Cat : Animal
    {
        public override void Shout()
        {
            Console.WriteLine(" 我是小猫喵喵叫!");
        }
    }

    class Dog : Animal
    {
        public override void Shout()
        {
            Console.WriteLine("我是小狗汪汪叫!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            animal = new Cat();
            animal.Shout();
            animal.Walk();
            animal = new Dog();
            animal.Shout();
            animal.Walk();
            Console.ReadKey();
        }
    }
}
