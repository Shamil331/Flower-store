
namespace opbd
{
    partial class AdminForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.myLine1 = new opbd.MyLine();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(297, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 372);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-mail: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин: ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(43, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Enabled = false;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "User",
            "Manager",
            "Admin"});
            this.comboBoxRole.Location = new System.Drawing.Point(44, 155);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(188, 24);
            this.comboBoxRole.TabIndex = 12;
            // 
            // buttonRole
            // 
            this.buttonRole.Enabled = false;
            this.buttonRole.Location = new System.Drawing.Point(44, 111);
            this.buttonRole.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRole.Name = "buttonRole";
            this.buttonRole.Size = new System.Drawing.Size(189, 37);
            this.buttonRole.TabIndex = 11;
            this.buttonRole.Text = "Сменить роль";
            this.buttonRole.UseVisualStyleBackColor = true;
            this.buttonRole.Click += new System.EventHandler(this.buttonRole_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(43, 187);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(189, 37);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить пользователя";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // myLine1
            // 
            this.myLine1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.myLine1.Location = new System.Drawing.Point(16, 86);
            this.myLine1.Margin = new System.Windows.Forms.Padding(4);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(267, 2);
            this.myLine1.TabIndex = 14;
            this.myLine1.Text = "myLine1";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(43, 304);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Изменить баланс пользователя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(44, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 16;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myLine1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.buttonRole);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonDelete;
        private MyLine myLine1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}