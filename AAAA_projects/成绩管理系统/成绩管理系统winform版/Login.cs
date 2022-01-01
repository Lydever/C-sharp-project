using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace 成绩管理系统winform版
{
    public partial class Login : Form
    {
        //private static string ConnStr = @"Data Source=DESKTOP-P09LKJ6;Initial Catalog=MyData;Integrated Security=true;";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string psd = textBox2.Text;
            //用原始的ado.net方法来进行数据库登录验证
            //using (SqlConnection conn = new SqlConnection(ConnStr))
            //{
            //    string sqlStr = "select name,password from 学生 where name='" +name + "'; ";
            //    SqlCommand command = new SqlCommand(sqlStr, conn);
            //    conn.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataSets.UserData = new DataSet();
            //    //之所以放入dataset,一是可以增强可读性，而是方便后续对该数据的访问
            //    adapter.Fill(DataSets.UserData, "UserData");
            //    if(DataSets.UserData.Tables["UserData"].Rows.Count > 0)
            //    {
            //        DataRow data = DataSets.UserData.Tables["UserData"].Select().First();
            //        if (psd.Equals(data["password"].ToString()))
            //        {
            //            //System.Diagnostics.Debug.WriteLine("登录成功！");
            //            MainForm mainForm = new MainForm();
            //            this.Hide();
            //            mainForm.ShowDialog();
            //        }
            //    }
            //    else
            //    {
            //        System.Diagnostics.Debug.WriteLine("该用户不存在");
            //    }
            //}

            //用linq to sql来进行登录验证
            StudentDataContext context = new StudentDataContext(Program.ConnStr);
            Table<Student> stus = context.Student;
            var ThisStu = stus.Where(stu => stu.number.Equals(name)).Select(stu=>stu).FirstOrDefault();
            //20180101ZC 张三
            //20170201HG 可可
            //20170203YU 马小腾
            if (ThisStu == null)
                System.Diagnostics.Debug.WriteLine("no this student exists!");
            else
            {
                if (ThisStu.password.Equals(psd))
                {
                    Student.LoginedStudent = ThisStu;
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("password wrong!");
                }
            }
        }
    }
}
