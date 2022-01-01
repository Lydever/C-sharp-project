using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统winform版
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            Student stu = new Student();
            SharedLayout.showStudentMessage(this, stu);
        }
    }
}
