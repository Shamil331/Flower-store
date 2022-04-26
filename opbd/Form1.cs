using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opbd
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                foreach (Book book in db.Books)
                    listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
            }
        }
        private void EntertoBookShop()
        {
            string admin = ".";
            if (Context.hiRole == "Admin" || Context.hiRole == "Manager")
            {
                buttonAddBook.Enabled = true;
                buttonRemoveBook.Enabled = true;
                buttonChange.Enabled = true;
                if (Context.hiRole == "Admin")
                {
                    groupBoxPanel.Text = "Панель админа";
                    buttonAdmin.Enabled = true;
                    groupBoxPanel.Height = 233;
                    admin = " (высший уровень доступа).";
                }
                else
                {
                    groupBoxPanel.Text = "Панель менеджера";
                    groupBoxPanel.Height = 188;
                }
            }
            if (Context.hiString != "Войти")
            {
                labelHi.Left = labelHi.Left - (labelHi.Text.Length + 18) * 7;
                labelHi.Text = "Добро пожаловать, " + Context.hiString;
                labelShowRole.Text = "Статус: " + Context.hiRole + admin;
                labelShowEmail.Text = "Email: " + Context.Email + ".";
                label1.Text = "Баланс";
                label2.Text = Convert.ToString(Context.Balance);
                labelRePass.Enabled = true;
                labelRePass.Visible = true;
            }
        }
        private void labelHi_Click(object sender, EventArgs e)
        {
            if (labelHi.Text == "Войти")
            {
                Autorization formEnter = new Autorization();
                formEnter.ShowDialog();
                EntertoBookShop();
            }
            else
            {
                labelRePass.Enabled = false;
                labelRePass.Visible = false;
                groupBoxPanel.Text = "Панель управления";
                using (Context bdb = new Context()) /////////////// не надо
                {
                    listBoxBooks.Items.Clear();
                    foreach (Book book in bdb.Books)
                        listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
                }
                labelHi.Text = "Войти";
                Context.hiString = "Войти";
                Context.hiRole = "";
                labelHi.Location = new Point(542, 17);
                labelHi.MinimumSize = new Size(50, 2);
                labelShowRole.Text = " ";
                labelShowEmail.Text = " ";
                label1.Text = " ";
                label2.Text = " ";
                groupBoxPanel.Height = 120;
                buttonAddBook.Enabled = false;
                buttonRemoveBook.Enabled = false;
                buttonChange.Enabled = false;
                buttonAdmin.Enabled = false;
            }
        }

        private void labelRePass_Click(object sender, EventArgs e)
        {
            FormRePass repass = new FormRePass();
            repass.ShowDialog();
            if (Context.IsRePass == true)
                MessageBox.Show("Пароль изменён успешно!", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                buttonBuy.Enabled = true;
                buttonDiscription.Enabled = true;
            }
            else
            {
                buttonBuy.Enabled = false;
                buttonDiscription.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (Context bdb = new Context())
            {
                if (textBoxSearch.Text != "")
                {
                    Book book = bdb.Books.Where(x => x.Name == textBoxSearch.Text).FirstOrDefault();
                    if (book != null)
                    {
                        listBoxBooks.SelectedItem = book.Name + " | " + book.Price + "руб. | " + book.Author;
                        textBoxSearch.Text = "";
                    }
                    else
                        MessageBox.Show("Такой книги в каталоге нет", "Каталог книг", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Введите название книги в поле.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BookBuy()
        {
            DialogResult result = MessageBox.Show("Вы подтверждаете покупку данной книги?", "Покупка книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DateTime dateTime = DateTime.Now;
                using (Context bdb = new Context())
                {
                    Book buy = bdb.Books.Where(x => x.Name + " | " + x.Price + "руб. | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
                    try
                    {
                        MailAddress from = new MailAddress("shigabiev.shamil@mail.ru", "Shamil");
                        MailAddress to = new MailAddress(Context.Email);
                        MailMessage m = new MailMessage(from, to);
                        m.Subject = "Книжный магазин";
                        using (Context db = new Context())
                        {
                            foreach (User user in db.Users)
                            {
                                if (Context.Email == user.Email)
                                {
                                    m.Body = "<h1>Спасибо за покупку книги " + buy.Name + "!</h1>\nДата совершения покупки: " + dateTime.ToString("dd.MM.yyyy") + ", " + dateTime.ToString("HH:mm:ss") + "\n<h3>Сумма покупки: " + buy.Price + "</h3>";
                                    Buy buuy = new Buy(buy.Id, buy.Name, buy.Price, user.Id, user.Login);
                                    db.Buys.Add(buuy);
                                    user.Balance -= buy.Price;
                                    label2.Text = Convert.ToString(user.Balance);
                                    //db.SaveChanges();
                                    //break;
                                }
                            }
                           // bdb.SaveChanges();
                            db.SaveChanges();
                        }                               
                       // bdb.SaveChanges();
                        m.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                        smtp.Credentials = new NetworkCredential("shigabiev.shamil@mail.ru", "Shamil252003");
                        smtp.EnableSsl = true;
                        smtp.Send(m);
                        
                        bdb.Books.Remove(buy);
                        bdb.SaveChanges();
                        listBoxBooks.Items.Clear();
                        foreach (Book book in bdb.Books)
                            listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
                    }
                    catch
                    { MessageBox.Show("Вы ввели неверный адрес электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (labelHi.Text == "Войти")
            {
                Autorization formEnter = new Autorization();
                formEnter.ShowDialog();
                if (Context.hiString != "Войти")
                {
                    EntertoBookShop();
                    BookBuy();
                    
                }
            }
            else
                BookBuy();
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);

                return img;
            }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void buttonDiscription_Click(object sender, EventArgs e)
        {
            using (Context bdb = new Context())
            {
                Book discription = bdb.Books.Where(x => x.Name + " | " + x.Price + "руб. | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
                Discription dis = new Discription();
                dis.Show();
                Image img;
                img = byteArrayToImage(discription.Photo);

                dis.pictureBox1.Image = ResizeImage(img, dis.pictureBox1.Width, dis.pictureBox1.Height);
                dis.Text = discription.Name;
                dis.label1.Text += " " + discription.Name;
                dis.label2.Text += " " + discription.Description;
                dis.label3.Text += " " + Convert.ToString(discription.Price);
                dis.label4.Text += " " + discription.Author;
                MessageBox.Show("Название: " + discription.Name + "\nАвтор: " + discription.Author + "\nОписание: " + discription.Description, discription.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void label15_MouseEnter(object sender, EventArgs e) // кнопка при наведении на нее курсора
        {
            if (labelHi.Text != "Войти")
            {
                labelHi.Text = "Выйти из профиля";
                labelHi.MinimumSize = new Size(Context.hiString.Length * 9, 20);
                labelHi.Left = this.Width - labelHi.Text.Length * 12;
            }
            labelHi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            labelHi.Top += 1;
            labelHi.Left += 1;
        }

        private void label15_MouseLeave(object sender, EventArgs e) // кнопка когда курсор отведен
        {
            if (labelHi.Text != "Войти")
                labelHi.Text = Context.hiString;
            labelHi.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            labelHi.Left = this.Width - Context.hiString.Length * 17;
            labelHi.Top -= 1;
            labelHi.Left -= 1;
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Enabled = true;
            admin.Visible = true;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Library lib = new Library();
            lib.ShowDialog();
            using (Context bdb = new Context())
            {
                listBoxBooks.Items.Clear();
                foreach (Book book in bdb.Books)
                    listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Library lib = new Library();
            lib.ShowDialog();
            using (Context bdb = new Context())
            {
                listBoxBooks.Items.Clear();
                foreach (Book book in bdb.Books)
                    listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
            }
        }

        private void buttonRemoveBook_Click_1(object sender, EventArgs e)
        {
            Library lib = new Library();
            lib.ShowDialog();
            using (Context bdb = new Context())
            {
                listBoxBooks.Items.Clear();
                foreach (Book book in bdb.Books)
                    listBoxBooks.Items.Add(book.Name + " | " + book.Price + "руб. | " + book.Author);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakaz zak = new Zakaz();
            zak.ShowDialog();
        }
    }

    //public User() //ЕСЛИ ИСЧЕЗНЕТ!!!
    //{ }
    //public User(string Login, string Password, string Email, string Role)
    //{
    //    this.Login = Login;
    //    this.Password = Password;
    //    this.Role = Role;
    //    this.Email = Email;
    //    this.Balance = 10000;
    //    this.Bought_books = "";
    //}



    //public Book()
    //{ }
    //public Book(string N, string D, int P, string A, byte[] Photo)
    //{
    //    this.Name = N;
    //    this.Description = D;
    //    this.Price = P;
    //    this.Author = A;
    //    this.Photo = Photo;
    //}
}
