﻿namespace Contact_Manage
{
    partial class Mdfct_Acct_Username
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_NewUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前用户名";
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(103, 58);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(157, 21);
            this.tB_Username.TabIndex = 1;
            // 
            // tB_NewUsername
            // 
            this.tB_NewUsername.Location = new System.Drawing.Point(103, 108);
            this.tB_NewUsername.Name = "tB_NewUsername";
            this.tB_NewUsername.Size = new System.Drawing.Size(157, 21);
            this.tB_NewUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "修改用户名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Mdfct_Acct_Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_NewUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.label1);
            this.Name = "Mdfct_Acct_Username";
            this.Text = "修改账户名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_NewUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}