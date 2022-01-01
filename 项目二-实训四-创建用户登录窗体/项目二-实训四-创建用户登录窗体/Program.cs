using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 项目二_实训四_创建用户登录窗体
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
