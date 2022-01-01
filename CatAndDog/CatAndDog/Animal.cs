using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatAndDog
{
    class Animal
    {
        public abstract class Animal    //创建Animal类
        {
            public Animal() { }
            public Animal(string nick, int age, string species)
            {
                this.Nick = nick;
                this.Age = age;
                this.Species = species;
            }

            //私有字段
            private int age;        //年龄
            private string nick;  //昵称
            private string species;  //品种

            //公有属性
            public int Age
            {
                get { return age; }
                set 
                {
                    if (value > 0 && value < 100)
                        age = value;
                    else
                        age = 1;
                }
            }

            public string Nick
            {
                get { return nick; }
                set { nick = value; }
            }

            public string Species
            {
                get { return species; }
                set { species = value; }
            }
            public abstract string Shout();
        }
    }
}
