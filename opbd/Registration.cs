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
    public partial class Registration : Form
    {
        public static bool IsEnter = false;
        private bool help;
        public Registration()
        {
            InitializeComponent();
        }
        private bool IsFree(string log, string mail)
        {
            using (Context db = new Context())
            {
                foreach (User user in db.Users)
                {
                    if (user.Login == log)
                    {
                        if (user.Email == mail)
                            help = true;
                        return false;
                    }
                }
                foreach (User user in db.Users)
                    if (user.Email == mail)
                        return false;
            }
            return true;
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text != "" && textBoxPass.Text != "" && textBoxEmail.Text != "")
            {
                using (Context db = new Context())
                {
                    if (IsFree(textBoxLog.Text, textBoxEmail.Text))
                    {
                        if (textBoxPass.Text.Length > 4)
                        {
                            User user = new User(textBoxLog.Text, Context.GetHashString(textBoxPass.Text), textBoxEmail.Text, "User");
                            db.Users.Add(user);
                            db.SaveChanges();
                            if (Context.hiString == "Войти")
                            {
                                Context.hiString = user.Login;
                                Context.hiRole = user.Role;
                                Context.Email = user.Email;
                            }
                            IsEnter = true;
                            this.Close();
                            return;
                        }
                        else
                            labelInfo.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (help == true)
                        {
                            DialogResult result = MessageBox.Show("Такой аккаунт уже есть.\nВы пытаетесь восстановить пароль?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                Autorization repass = new Autorization();
                                repass.newPass(textBoxLog.Text);
                            }
                        }
                        else
                            MessageBox.Show("Пользователь с таким аккаунтом уже существует.");
                    }
                }
            }
            else
            {
                if (textBoxLog.Text == "")
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;

                if (textBoxPass.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;

                if (textBoxEmail.Text == "")
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Black;
            }
        }

        private void Registration_Load_1(object sender, EventArgs e)
        {

        }
    }
}
