using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 猫狗继承问题
{
    public class Animal    // 创建Animal 类
    {
        public Animal() { }    // 构造函数的声明
        public Animal(string nick, int age, string species)
        {
            this.Nick = nick;
            this.Age = age;
            this.Species = species;
        }

        //私有字段
        private int age;
        private string nick;
        private string species;


        //公有属性
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }

        public string Nick
        {
            get
            {
                return nick;
            }
            set
            {
                nick = value;
            }
        }

        public string Species
        { 
           get
           {
               return species;
           }
            set 
            {
                species = value;
            }
        }
    }

}
