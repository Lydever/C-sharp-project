using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace 集合_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add("java");
            arrlist.Add("php");
            arrlist.Add("ASP.net");
            arrlist.Add("python");
            arrlist.Add("HTML");
            arrlist.Add("javascript");
            foreach (int n in new int[6] { 0, 1, 2, 3, 4, 5 })
            {
                arrlist.Add(n);
            }
                arrlist.Remove(0);
                arrlist.RemoveAt(5);
                arrlist.Insert(1,"javascript");
                for (int i = 0; i < arrlist.Count; i++)
                {
                    Console.WriteLine(arrlist[i].ToString());
                    Console.ReadKey();
            }
        }
    }
}
