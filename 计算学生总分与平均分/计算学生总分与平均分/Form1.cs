using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算学生总分与平均分
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        static public double total(double chinese, double math, double english, double che) 
        {//计算总分方法
            double s=0;
            s = chinese+math+english+che;
            return s;
        }

        static public float average(double s)
        {//计算平均分方法
            float  m;
            m = (float)s/4;
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {            //获取各科的成绩
            double chinese = Convert.ToDouble(textBox1.Text.ToString());
            double math = Convert.ToDouble(textBox2.Text.ToString());
            double english = Convert.ToDouble(textBox4.Text.ToString());
            double che = Convert.ToDouble(textBox5.Text.ToString());
            //调用计算总分的方法
            double s = total(chinese,math,english,che);
            textBox3.Text = Math.Round(s, 2).ToString();
            //调用计算平均分的方法
            double a = average(s);
            textBox6.Text = Math.Round(a, 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {//退出
            Application.Exit();
        }

    }
}
