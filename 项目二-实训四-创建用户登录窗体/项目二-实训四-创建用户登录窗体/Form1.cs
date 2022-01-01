using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 项目二_实训四_创建用户登录窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("欢迎" + textBox1.Text + "!");
            }
            else
            {
                MessageBox.Show("用户名或密码错误!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // 清空用户名
            textBox2.Text = ""; // 清空密码
        }
    }
}
