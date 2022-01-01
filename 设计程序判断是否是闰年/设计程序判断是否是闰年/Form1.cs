using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 设计程序判断是否是闰年
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //判断buton事件处理
        private void button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    int maxNum = int.MaxValue;
                    int minNum = int.MinValue;//判断是否溢出

                    int y = Convert.ToInt32(textBox1.Text);
                    maxNum = y;
                    minNum = y;

                    //判断是否为闰年
                    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                    {
                        MessageBox.Show("你输入的是闰年!", "判断是否为闰年");
                    }
                    else
                    {
                        MessageBox.Show("你输入的不是闰年!", "判断是否为闰年");
                    }
                }

                catch (FormatException)
                {
                    MessageBox.Show("输入的字符串不正确!", "输入有误!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("输入的值太大或太小", "判断是否为闰年");
                }
            }
        }

        //取消buton清空处理
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
