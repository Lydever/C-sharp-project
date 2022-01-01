using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 猫狗继承问题
{
public  class dog:Animal
    {
    public dog() { }
    public dog(string nick, int age, string species, int popularity)
    {
        this.Nick = nick;
        this.Age = age;
        this.Species = species;
        this.Popularity = popularity;
    }
        private int popularity;
        private int Popularity
        {
          get{return popularity;}
            set { popularity = value; }
        }


        public string Shout()
        {
            string s;
            s= string .Format("大家好,我是小狗{0},今年{1}岁了,我属于{2},我的人气指数是{3}",this.Nick,this.Age,this.Species,this.Popularity);
            return s;
        }

    }
}
