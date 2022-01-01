
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统winform版
{
    class SharedLayout
    {
        public static void showStudentMessage(Form form,Student stu)
        {
            Panel panel = new Panel();
            panel.SetBounds(0, 0, form.ClientSize.Width, 50);
            panel.BorderStyle = BorderStyle.FixedSingle;
            form.Controls.Add(panel);

            Font font = new Font("微软雅黑", 12);

            Label namel= new Label();
            namel.Text = "姓名：" + stu.name;
            namel.Font = font;
            namel.SetBounds(10, 10, 160, 60);
            panel.Controls.Add(namel);

            Label classl = new Label();
            //这里的text涉及到ado.net操作
            StudentDataContext context = new StudentDataContext(Program.ConnStr);
            var msg = context._Class.Where(cls => cls.id.Equals(stu.classid))
                .Select(cls => new { cls.grade, cls.number }).FirstOrDefault();
            classl.Text = "班级：初" + msg.grade + "年级" + msg.number + "班";
            classl.SetBounds(200, 10, 160, 60);
            classl.Font = font;
            panel.Controls.Add(classl);

            Label stuNol = new Label();
            stuNol.Text = "学号："+ stu.number;
            stuNol.SetBounds(390, 10, 160, 60);
            stuNol.Font = font;
            panel.Controls.Add(stuNol);
        }
    }
}
