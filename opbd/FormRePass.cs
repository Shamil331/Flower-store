using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opbd
{
    public partial class FormRePass : Form
    {
        public FormRePass()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormRePass_Load(object sender, EventArgs e)
        {
            labelShowLogin.Text = "Имя пользователя: " + Context.hiString;
            labelShowEmail.Text = "Email: " + Context.Email;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text != "" && textBoxNewPassword.Text != "")
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                using (Context db = new Context())
                {
                    bool check = false;
                    foreach (User user in db.Users)
                    {
                        if ((Context.hiString == user.Login && Context.GetHashString(textBoxOldPassword.Text) == user.Password) || (Context.hiString == user.Login && textBoxOldPassword.Text == user.Password))
                        {
                            check = true;
                            labelPassNo.Text = "";
                            if (textBoxNewPassword.Text.Length > 4)
                            {
                                user.Password = Context.GetHashString(textBoxNewPassword.Text);
                                Context.IsRePass = true;
                            }
                            else
                                labelInfo.ForeColor = Color.Red;
                        }
                    }
                    if (check == false)
                    {
                        if (textBoxNewPassword.Text.Length > 4)
                            labelInfo.ForeColor = Color.Black;
                        else
                            labelInfo.ForeColor = Color.Red;
                        labelPassNo.Text = "Неверный пароль!";
                    }
                    if (Context.IsRePass == true)
                    {
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите необходимые поля!");
                if (textBoxNewPassword.Text == "")
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;

                if (textBoxOldPassword.Text == "")
                    label1.ForeColor = Color.Red;
                else
                {
                    label1.ForeColor = Color.Black;
                    using (Context db = new Context())
                    {
                        foreach (User user in db.Users)
                        {
                            if ((Context.hiString == user.Login && Context.GetHashString(textBoxOldPassword.Text) == user.Password) || (Context.hiString == user.Login && textBoxOldPassword.Text == user.Password))
                            {
                                labelPassNo.Text = "";
                                return;
                            }
                        }
                        labelPassNo.Text = "Неверный пароль!";
                        return;
                    }
                }
            }
        }
    }
    class MyLine : System.Windows.Forms.Control
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(this.ForeColor, this.Width);
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
            base.OnPaint(e);
        }
    }
}
