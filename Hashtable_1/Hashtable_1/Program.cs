using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace Hashtable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable student = new Hashtable();
            student.Add("S1001", "Tom");
            student.Add("S1002", "Jim");
            student.Add("S1003", "Lily");
            student.Add("S1004", "Lucy");
            foreach (DictionaryEntry element in student)
            {
                string id = element.Key.ToString();
                string name = element.Value.ToString();
               Console.WriteLine(" 学生的ID ：{0} 学生姓名：{1}",id,name); }
               student.Remove("S1003");
               Console.ReadKey();
           }
     }
}
