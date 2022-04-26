
namespace opbd
{
    partial class Library
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFinalChange = new System.Windows.Forms.Button();
            this.richTextBoxBookDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookPrice = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(26, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 45);
            this.button3.TabIndex = 55;
            this.button3.Text = "Выбрать из файла";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Фотография:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelInfo.Location = new System.Drawing.Point(197, 32);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(147, 17);
            this.labelInfo.TabIndex = 53;
            this.labelInfo.Text = "Изменений не было..";
            this.labelInfo.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(197, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 44);
            this.button2.TabIndex = 52;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 44);
            this.button1.TabIndex = 51;
            this.button1.Text = "Добавить в библиотеку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFinalChange
            // 
            this.buttonFinalChange.Enabled = false;
            this.buttonFinalChange.Location = new System.Drawing.Point(197, 112);
            this.buttonFinalChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinalChange.Name = "buttonFinalChange";
            this.buttonFinalChange.Size = new System.Drawing.Size(191, 44);
            this.buttonFinalChange.TabIndex = 50;
            this.buttonFinalChange.Text = "Изменить книгу";
            this.buttonFinalChange.UseVisualStyleBackColor = true;
            this.buttonFinalChange.Click += new System.EventHandler(this.buttonFinalChange_Click);
            // 
            // richTextBoxBookDescription
            // 
            this.richTextBoxBookDescription.Location = new System.Drawing.Point(23, 80);
            this.richTextBoxBookDescription.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxBookDescription.Name = "richTextBoxBookDescription";
            this.richTextBoxBookDescription.Size = new System.Drawing.Size(132, 117);
            this.richTextBoxBookDescription.TabIndex = 49;
            this.richTextBoxBookDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Автор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Имя:";
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(23, 281);
            this.textBoxBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(132, 22);
            this.textBoxBookAuthor.TabIndex = 44;
            // 
            // textBoxBookPrice
            // 
            this.textBoxBookPrice.Location = new System.Drawing.Point(23, 227);
            this.textBoxBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookPrice.Name = "textBoxBookPrice";
            this.textBoxBookPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxBookPrice.TabIndex = 43;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(23, 32);
            this.textBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(132, 22);
            this.textBoxBookName.TabIndex = 42;
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(466, 13);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(339, 308);
            this.listBoxBooks.TabIndex = 41;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 395);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFinalChange);
            this.Controls.Add(this.richTextBoxBookDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.textBoxBookPrice);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button buttonFinalChange;
        private System.Windows.Forms.RichTextBox richTextBoxBookDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.TextBox textBoxBookPrice;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}