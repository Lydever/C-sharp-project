using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatAndDog
{
  public class Dog:Animal
{ public Dog() { } // 构造函数的声明
public Dog(string nick, int age, string species, int popularity):base(nick,age,species)
{ // 继承自父类的属性
this.Nick = nick;
this.Age = age;
this.Species = species;
this.Popularity = popularity; }// 狗类扩展的属性
private int popularity; // 人气指数的字段和属性的声明
public int Popularity
{ get { return popularity; }
set { popularity = value; } }
public override string Shout() //重写基 重写基类的抽象方法 类的抽象方法
{ string s;
s = string.Format(" 大家好，我是小狗{0} ，今年{1} 岁了，我属于{2} ，我的人气指数是 我的人气指数是{3} ！",this.Nick, this.Age, this.Species, this.Popularity);
return s; }}
}
