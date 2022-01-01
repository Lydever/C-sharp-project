using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyButton
{
    public partial class UserControl1: UserControl
    {
        public Label label1;
        public Button button1;
        public UserControl1()
        {
            InitializeComponent();
            label1 = new Label();
            button1 = new Button();
            int h1 = (int)(this.Size.Height * 0.30);
            label1.SetBounds(0, 0, this.Size.Width, h1);
            button1.SetBounds(0, h1, this.Size.Width, this.Size.Height - h1);
            this.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        public void SetFont(Font font)
        {
            label1.Font = font;
            button1.Font = font;
        }
       public void SetName(string name)
        {
            label1.Text = name;
        }
        public void SetValue(string value)
        {
            button1.Text = value;
        }
        public void SetClickEvent(EventHandler eventHandler)
        {
            button1.Click += eventHandler;
        }
    }
}
