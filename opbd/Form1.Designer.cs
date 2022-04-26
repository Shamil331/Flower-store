
namespace opbd
{
    partial class UserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRePass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDiscription = new System.Windows.Forms.Button();
            this.labelHi = new System.Windows.Forms.Label();
            this.labelShowEmail = new System.Windows.Forms.Label();
            this.labelShowRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRePass
            // 
            this.labelRePass.AutoSize = true;
            this.labelRePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRePass.Enabled = false;
            this.labelRePass.Font = new System.Drawing.Font("Calibri Light", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRePass.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelRePass.Location = new System.Drawing.Point(652, 65);
            this.labelRePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRePass.Name = "labelRePass";
            this.labelRePass.Size = new System.Drawing.Size(144, 21);
            this.labelRePass.TabIndex = 45;
            this.labelRePass.Text = "Поменять пароль";
            this.labelRePass.Visible = false;
            this.labelRePass.Click += new System.EventHandler(this.labelRePass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxBooks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(301, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(497, 393);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог";
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Location = new System.Drawing.Point(8, 23);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(480, 324);
            this.listBoxBooks.TabIndex = 7;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.buttonAddBook);
            this.groupBoxPanel.Controls.Add(this.buttonChange);
            this.groupBoxPanel.Controls.Add(this.buttonAdmin);
            this.groupBoxPanel.Controls.Add(this.buttonRemoveBook);
            this.groupBoxPanel.Controls.Add(this.buttonSearch);
            this.groupBoxPanel.Controls.Add(this.textBoxSearch);
            this.groupBoxPanel.Controls.Add(this.buttonBuy);
            this.groupBoxPanel.Controls.Add(this.buttonDiscription);
            this.groupBoxPanel.Location = new System.Drawing.Point(20, 87);
            this.groupBoxPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPanel.Size = new System.Drawing.Size(273, 144);
            this.groupBoxPanel.TabIndex = 43;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Панель управления";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Enabled = false;
            this.buttonAddBook.Location = new System.Drawing.Point(143, 150);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(123, 28);
            this.buttonAddBook.TabIndex = 8;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(68, 186);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(136, 28);
            this.buttonChange.TabIndex = 23;
            this.buttonChange.Text = "Изменить книгу";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Enabled = false;
            this.buttonAdmin.Location = new System.Drawing.Point(8, 240);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(243, 28);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Пользователи";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Enabled = false;
            this.buttonRemoveBook.Location = new System.Drawing.Point(8, 150);
            this.buttonRemoveBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(123, 28);
            this.buttonRemoveBook.TabIndex = 18;
            this.buttonRemoveBook.Text = "Удалить книгу";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(8, 34);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 28);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Найти книгу";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.Color.MediumPurple;
            this.textBoxSearch.Location = new System.Drawing.Point(8, 70);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(256, 22);
            this.textBoxSearch.TabIndex = 21;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Enabled = false;
            this.buttonBuy.Location = new System.Drawing.Point(143, 34);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(123, 28);
            this.buttonBuy.TabIndex = 22;
            this.buttonBuy.Text = "Купить книгу";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDiscription
            // 
            this.buttonDiscription.Enabled = false;
            this.buttonDiscription.Location = new System.Drawing.Point(8, 102);
            this.buttonDiscription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDiscription.Name = "buttonDiscription";
            this.buttonDiscription.Size = new System.Drawing.Size(257, 28);
            this.buttonDiscription.TabIndex = 19;
            this.buttonDiscription.Text = "Посмотреть описание";
            this.buttonDiscription.UseVisualStyleBackColor = true;
            this.buttonDiscription.Click += new System.EventHandler(this.buttonDiscription_Click);
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHi.Location = new System.Drawing.Point(723, 18);
            this.labelHi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHi.MaximumSize = new System.Drawing.Size(333, 37);
            this.labelHi.MinimumSize = new System.Drawing.Size(67, 2);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(70, 24);
            this.labelHi.TabIndex = 42;
            this.labelHi.Text = "Войти";
            this.labelHi.Click += new System.EventHandler(this.labelHi_Click);
            this.labelHi.MouseEnter += new System.EventHandler(this.label15_MouseEnter);
            this.labelHi.MouseLeave += new System.EventHandler(this.label15_MouseLeave);
            // 
            // labelShowEmail
            // 
            this.labelShowEmail.AutoSize = true;
            this.labelShowEmail.Location = new System.Drawing.Point(16, 46);
            this.labelShowEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowEmail.Name = "labelShowEmail";
            this.labelShowEmail.Size = new System.Drawing.Size(12, 17);
            this.labelShowEmail.TabIndex = 41;
            this.labelShowEmail.Text = " ";
            // 
            // labelShowRole
            // 
            this.labelShowRole.AutoSize = true;
            this.labelShowRole.Location = new System.Drawing.Point(16, 18);
            this.labelShowRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowRole.Name = "labelShowRole";
            this.labelShowRole.Size = new System.Drawing.Size(12, 17);
            this.labelShowRole.TabIndex = 40;
            this.labelShowRole.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 45);
            this.button1.TabIndex = 48;
            this.button1.Text = "История заказов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.labelShowEmail);
            this.Controls.Add(this.labelShowRole);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRePass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        public System.Windows.Forms.Button buttonAddBook;
        public System.Windows.Forms.Button buttonChange;
        public System.Windows.Forms.Button buttonAdmin;
        public System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonDiscription;
        public System.Windows.Forms.Label labelHi;
        public System.Windows.Forms.Label labelShowEmail;
        public System.Windows.Forms.Label labelShowRole;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

