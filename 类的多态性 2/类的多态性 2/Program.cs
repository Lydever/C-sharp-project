using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的多态性_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawObject[] obj = new DrawObject[4];
            obj[0] = new DrawLine();
            obj[1] = new DrawCircle();
            obj[2] = new DrawRectangle();
            obj[3] = new DrawObject();
            foreach (DrawObject drawObj in obj)
            {
                drawObj.Draw();
            }
            Console.ReadKey();
        }
    }
}
