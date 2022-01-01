using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统winform版
{
    public partial class MainForm : Form
    {
        string ExamName { set; get; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Student stu = Student.LoginedStudent;
            SharedLayout.showStudentMessage(this, stu);

            Font font = new Font("微软雅黑", 16);
            subject1.SetFont(font);
            subject1.label1.TextAlign = ContentAlignment.MiddleCenter;
            subject1.SetName("语文");

            subject2.SetFont(font);
            subject2.label1.TextAlign = ContentAlignment.MiddleCenter;
            subject2.SetName("数学");

            subject3.SetFont(font);
            subject3.label1.TextAlign = ContentAlignment.MiddleCenter;
            subject3.SetName("科学");

            subject4.SetFont(font);
            subject4.label1.TextAlign = ContentAlignment.MiddleCenter;
            subject4.SetName("英语");

            subject5.SetFont(font);
            subject5.label1.TextAlign = ContentAlignment.MiddleCenter;
            subject5.SetName("总分");

            //寻找与该学生相关的考试名，并给combobox赋值
            //comboBox1.Items.Add("whatfuck");
            //找出该学生所在的段，再找出考试表里与该段相等的名字
            StudentDataContext context = new StudentDataContext(Program.ConnStr);
            Table<_Class> _class = context._Class;
            var grade = _class.Where(cls => cls.id.Equals(stu.classid)).Select(cls => cls.grade).FirstOrDefault();
            //假设grade一定存在
            Table<Exam> exams = context.Exam;
            var query = exams.Where(exam => exam.grade.Equals(grade)).Select(exam=>exam.name).Distinct();
            foreach (var exam in query)
            {
                comboBox1.Items.Add(exam);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(comboBox1.SelectedItem.ToString());
            StudentDataContext context = new StudentDataContext(Program.ConnStr);
            //将考试表与成绩表做一个join，其join条件是考试表number与成绩表number相同
            //在join后的结果表中寻找学生Number和登录的学生number相同的，以及考试名称相同的记录
            var TempTable = from ex in context.Exam
                            join s in context.Score on ex.number equals s.number
                            select new { ex.name, ex.subject,s.stu_number,s.score };
            Student stu = Student.LoginedStudent;
            string SelectedName = comboBox1.SelectedItem.ToString();
            var ScoreList = (TempTable.AsQueryable().Where(s => s.name.Equals(SelectedName)
            && s.stu_number.Equals(stu.number)).Select(s => s)).ToList();

            decimal sum = 0;
            foreach (var score in ScoreList)
            {
                string ScoreToStr = score.score.ToString();
                switch (score.subject)
                {
                    case "语文":subject1.SetValue(ScoreToStr);break;
                    case "数学":subject2.SetValue(ScoreToStr);break;
                    case "科学": subject3.SetValue(ScoreToStr); break;
                    case "英语": subject4.SetValue(ScoreToStr); break;
                    default:
                        break;
                }
                sum += score.score;
            }
            subject5.SetValue(sum.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Student.LoginedStudent = null;
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
