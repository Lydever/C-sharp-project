using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的多态性_2
{
    public class DrawObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("在基类中绘制对象");
        }
    }

    public class DrawLine : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("我要画一条直线!");
        }
    }
    public class DrawCircle : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("我要画一个圆!");
        }
    }

    public class DrawRectangle : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("我要画一个矩形!");
        }
    }

}
