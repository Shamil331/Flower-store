using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opbd
{
    public partial class Autorization : Form
    {
        public bool check = false;
        public Autorization()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
            if (Registration.IsEnter == true)
            {
                Registration.IsEnter = false;
                this.Close();
            }
        }
        public void newPass(string log)
        {
            DateTime dateTime = DateTime.Now;
            try
            {
                using (Context db = new Context())
                {
                    foreach (User user in db.Users)
                    {
                        if (log == user.Login)
                        {
                            check = true;
                            DialogResult result = MessageBox.Show("Новый пароль будет отправлен на почту " + user.Email + ".\nПродолжить?", "Восстановление пароля", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                MailAddress from = new MailAddress("shigabiev.shamil@mail.ru", "Shamil");
                                MailAddress to = new MailAddress(user.Email);
                                MailMessage m = new MailMessage(from, to);
                                m.Subject = "Книжный магазин: восстановление пароля";
                                Random r = new Random();
                                int n = r.Next(5, 10);
                                string pass = "";
                                while (pass.Length < n)
                                {
                                    Char c = (char)r.Next(33, 125);
                                    if (Char.IsLetterOrDigit(c))
                                        pass += c;
                                }
                                user.Password = Context.GetHashString(pass);
                                m.Body = "Запрос на восстановление пароля от: " + dateTime.ToString("dd.MM.yyyy") + ", " + dateTime.ToString("HH:mm:ss") + "\nНовый пароль: <h1>" + pass + "</h1>";
                                m.IsBodyHtml = true;
                                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                                smtp.Credentials = new NetworkCredential("shigabiev.shamil@mail.ru", "Shamil252003");
                                smtp.EnableSsl = true;
                                smtp.Send(m);
                                MessageBox.Show("Новый пароль отправлен на почту!");
                                break;
                            }
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch
            { MessageBox.Show("Произошла ошибка!", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text != "")
            {
                newPass(textBoxLog.Text);
                if (check == false)
                {
                    MessageBox.Show("Пользователь с логином \"" + textBoxLog.Text + "\" не существует.", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Text = "Логин:";
                    label2.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show("Введите свой логин для получения нового пароля.", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.ForeColor = Color.Red;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text != "" && textBoxPass.Text != "")
            {
                using (Context db = new Context())
                {
                    foreach (User user in db.Users)
                    {
                        if ((textBoxLog.Text == user.Login && Context.GetHashString(textBoxPass.Text) == user.Password) || (textBoxLog.Text == user.Login && textBoxPass.Text == user.Password))
                        {
                            Context.hiString = user.Login;
                            Context.hiRole = user.Role;
                            Context.Email = user.Email;
                            Context.Balance = user.Balance;
                            Context.ID = user.Id;
                            this.Close();
                            return;
                        }
                    }
                    MessageBox.Show("Логин или пароль указан неверно!");
                    textBoxLog.Text = "";
                    textBoxPass.Text = "";
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
            }
        }
    }
}
