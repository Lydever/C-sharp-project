using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 圆和三角形的计算
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        static public double girth(double r)
        { //计算圆的周长的方法
            double s;
            s = 2 * Math.PI * r;
            return s;
        }
        static public double girth(double a, double b, double c) {
            double s;
            s = a + b + c;
            return s;
        }
        static public double area(double r) {
            double s;
            s = Math.PI * r * r;
            return s;
        }
        static public double area(double a, double b, double c) {
            double p;
            double s;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text.ToString());
            //调用计算周长的方法
            double L = girth(r);
            textBox2.Text = Math.Round(L, 2).ToString();
            //Math.Round()方法用于完成数据的四舍五入操作
            //调用计算面积的方法
            double S = area(r);
            textBox3.Text = Math.Round(S, 2).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();			
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //获取三边的数值
            double a = Convert.ToDouble(textBox4.Text.ToString());
            double b = Convert.ToDouble(textBox5.Text.ToString());
            double c = Convert.ToDouble(textBox6.Text.ToString());
            //调用计算周长的方法
            double L = girth(a, b, c);
            textBox7.Text = Math.Round(L, 2).ToString();
            //调用计算面积的方法
            double S = area(a, b, c);
            textBox8.Text = Math.Round(S, 2).ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
