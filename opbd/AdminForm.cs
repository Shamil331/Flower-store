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
    public partial class AdminForm : Form
    {
        Context db = new Context();
        public AdminForm()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Вы также можете восстановить пароль пользователя через форму регистрации.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration newUser = new Registration();
            newUser.ShowDialog();
            if (Registration.IsEnter == true)
            {
                Registration.IsEnter = false;
                MessageBox.Show("Пользователь добавлен!\nТеперь вы можете присвоить ему новую роль.");
                listBox1.Items.Clear();
                foreach (User x in db.Users)
                    listBox1.Items.Add(x.Id + " | " + x.Login + " | " + x.Email + " | " + x.Role+" | "+x.Balance);
            }
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            label1.Text += Context.hiString;
            label2.Text += Context.Email;
            foreach (User user in db.Users)
                listBox1.Items.Add(user.Id + " | " + user.Login + " | " + user.Email + " | " + user.Role+" | "+user.Balance);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            User delete = db.Users.Where(x => x.Id + " | " + x.Login + " | " + x.Email + " | " + x.Role+" | "+x.Balance == listBox1.SelectedItem).FirstOrDefault();
            if (delete != null)
            {
                buttonRole.Enabled = true;
                comboBoxRole.Enabled = true;
                buttonDelete.Enabled = true;
            }
            textBox1.Enabled = true;
        }

        private void buttonRole_Click_1(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem != null && listBox1.SelectedItem != null)
            {
                foreach (User user in db.Users)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == user.Id + " | " + user.Login + " | " + user.Email + " | " + user.Role+" | " +user.Balance)
                    {
                        if (user.Role != "Admin")
                        {
                            user.Role = Convert.ToString(comboBoxRole.SelectedItem);
                            buttonRole.Enabled = false;
                            comboBoxRole.Enabled = false;
                            buttonDelete.Enabled = false;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Вы не можете изменять роль админа", "Смена ролей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
                db.SaveChanges();
                listBox1.Items.Clear();
                foreach (User x in db.Users)
                    listBox1.Items.Add(x.Id + " | " + x.Login + " | " + x.Email + " | " + x.Role);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            User delete = db.Users.Where(x => x.Id + " | " + x.Login + " | " + x.Email + " | " + x.Role+" | "+x.Balance == listBox1.SelectedItem).FirstOrDefault();
            if (delete != null && delete.Role != "Admin")
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить пользователя " + delete.Login + "навсегда из сервиса?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Users.Remove(delete);
                    db.SaveChanges();
                    buttonRole.Enabled = false;
                    comboBoxRole.Enabled = false;
                    buttonDelete.Enabled = false;
                    listBox1.Items.Clear();
                    foreach (User user in db.Users)
                        listBox1.Items.Add(user.Id + " | " + user.Login + " | " + user.Email + " | " + user.Role + " | " + user.Balance);
                }
            }
            else
                MessageBox.Show("Вы не можете удалить пользователя с ролью админа!", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
            {
                User balance = db.Users.Where(x => x.Id + " | " + x.Login + " | " + x.Email + " | " + x.Role + " | " + x.Balance == listBox1.SelectedItem).FirstOrDefault();
                if (textBox1.Text!="")
                {
                    balance.Balance = Convert.ToInt32(textBox1.Text);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Введите нужный баланс");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя");
            }
            listBox1.Items.Clear();
            foreach (User user in db.Users)
                listBox1.Items.Add(user.Id + " | " + user.Login + " | " + user.Email + " | " + user.Role + " | " + user.Balance);
        }
    }
}
