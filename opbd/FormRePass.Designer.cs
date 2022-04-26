
namespace opbd
{
    partial class FormRePass
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
            this.labelPassNo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelShowEmail = new System.Windows.Forms.Label();
            this.labelShowLogin = new System.Windows.Forms.Label();
            this.myLine1 = new opbd.MyLine();
            this.SuspendLayout();
            // 
            // labelPassNo
            // 
            this.labelPassNo.AutoSize = true;
            this.labelPassNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassNo.ForeColor = System.Drawing.Color.Red;
            this.labelPassNo.Location = new System.Drawing.Point(208, 82);
            this.labelPassNo.Name = "labelPassNo";
            this.labelPassNo.Size = new System.Drawing.Size(10, 13);
            this.labelPassNo.TabIndex = 55;
            this.labelPassNo.Text = " ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(208, 106);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(123, 26);
            this.labelInfo.TabIndex = 54;
            this.labelInfo.Text = "Пароль должен иметь \r\nминимум 5 символов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(82, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Сменить";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Введите новый пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Введите текущий пароль:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(13, 24);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxOldPassword.TabIndex = 50;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(13, 75);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewPassword.TabIndex = 49;
            // 
            // labelShowEmail
            // 
            this.labelShowEmail.AutoSize = true;
            this.labelShowEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowEmail.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowEmail.Location = new System.Drawing.Point(211, 52);
            this.labelShowEmail.Name = "labelShowEmail";
            this.labelShowEmail.Size = new System.Drawing.Size(13, 18);
            this.labelShowEmail.TabIndex = 48;
            this.labelShowEmail.Text = " ";
            // 
            // labelShowLogin
            // 
            this.labelShowLogin.AutoSize = true;
            this.labelShowLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowLogin.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowLogin.Location = new System.Drawing.Point(211, 7);
            this.labelShowLogin.Name = "labelShowLogin";
            this.labelShowLogin.Size = new System.Drawing.Size(13, 18);
            this.labelShowLogin.TabIndex = 47;
            this.labelShowLogin.Text = " ";
            // 
            // myLine1
            // 
            this.myLine1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.myLine1.Location = new System.Drawing.Point(192, 12);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(2, 130);
            this.myLine1.TabIndex = 56;
            this.myLine1.Text = "myLine1";
            // 
            // FormRePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 154);
            this.Controls.Add(this.myLine1);
            this.Controls.Add(this.labelPassNo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelShowEmail);
            this.Controls.Add(this.labelShowLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRePass";
            this.Text = "FormRePass";
            this.Load += new System.EventHandler(this.FormRePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassNo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        public System.Windows.Forms.Label labelShowEmail;
        public System.Windows.Forms.Label labelShowLogin;
        private MyLine myLine1;
    }
}