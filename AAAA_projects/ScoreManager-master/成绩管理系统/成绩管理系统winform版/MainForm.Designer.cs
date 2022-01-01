namespace 成绩管理系统winform版
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.subject1 = new MyButton.UserControl1();
            this.subject2 = new MyButton.UserControl1();
            this.subject3 = new MyButton.UserControl1();
            this.subject4 = new MyButton.UserControl1();
            this.subject5 = new MyButton.UserControl1();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // subject1
            // 
            this.subject1.Location = new System.Drawing.Point(80, 172);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(80, 100);
            this.subject1.TabIndex = 4;
            // 
            // subject2
            // 
            this.subject2.Location = new System.Drawing.Point(243, 172);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(80, 100);
            this.subject2.TabIndex = 5;
            // 
            // subject3
            // 
            this.subject3.Location = new System.Drawing.Point(409, 172);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(80, 100);
            this.subject3.TabIndex = 6;
            // 
            // subject4
            // 
            this.subject4.Location = new System.Drawing.Point(568, 172);
            this.subject4.Name = "subject4";
            this.subject4.Size = new System.Drawing.Size(80, 100);
            this.subject4.TabIndex = 7;
            // 
            // subject5
            // 
            this.subject5.Location = new System.Drawing.Point(324, 342);
            this.subject5.Name = "subject5";
            this.subject5.Size = new System.Drawing.Size(80, 100);
            this.subject5.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subject5);
            this.Controls.Add(this.subject4);
            this.Controls.Add(this.subject3);
            this.Controls.Add(this.subject2);
            this.Controls.Add(this.subject1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理系统-主页";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MyButton.UserControl1 subject1;
        private MyButton.UserControl1 subject2;
        private MyButton.UserControl1 subject3;
        private MyButton.UserControl1 subject4;
        private MyButton.UserControl1 subject5;
        private System.Windows.Forms.Button button2;
    }
}