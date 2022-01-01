using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的多态性
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal_1 animal;
            animal = new Dog();
            animal.Shout();
            animal = new Cat();
            animal.Shout();
            animal = new Animal_1();
            animal.Shout();
            Console.ReadKey();
        }
    }
}
