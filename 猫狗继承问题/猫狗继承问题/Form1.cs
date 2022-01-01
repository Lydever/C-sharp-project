using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 猫狗继承问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("李子",2,"波斯猫","玩毛绒球");
            dog d = new dog(" 皮皮",5,"团团",3000);
            MessageBox.Show(cat.Shout());
            Console.ReadKey();
        }
               
    }

}
