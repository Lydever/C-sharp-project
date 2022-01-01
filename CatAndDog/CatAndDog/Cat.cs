using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatAndDog
{
    class Cat
    {
        public class Cat : Animal
        {
            public Cat() { }
            public Cat(string nick, int age, string species, string hobby)
            {
                this.Nick = nick;
                this.Age = age;
                this.Species = species;
                this.Hobby = hobby;
            }
            private string hobby;

            public string Hobby
            {
                get { return hobby; }
                set { hobby = value; }
            }
            public override string Shout()
            {
                string s;
                s = string.Format("大家好,我是小猫{0},今年{1}岁了,我属于{2},喜欢{3}!",this.Nick,this.Age,this.Species,this.hobby);
                return s;
            }
        }
    }
}
