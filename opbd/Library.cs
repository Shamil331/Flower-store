using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opbd
{
    public partial class Library : Form
    {
        Context bdb = new Context();
        public Library()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBookName.Text != "" && richTextBoxBookDescription.Text != "" && textBoxBookPrice.Text != "" && textBoxBookAuthor.Text != "")
            {
                if (Int32.TryParse(textBoxBookPrice.Text, out int k))
                {
                    openFileDialog1.ShowDialog();

                    byte[] imagefile = File.ReadAllBytes(openFileDialog1.FileName);
                    Book book = new Book(textBoxBookName.Text, richTextBoxBookDescription.Text, Convert.ToInt32(k), textBoxBookAuthor.Text, imagefile);
                    bdb.Books.Add(book);
                    bdb.SaveChanges();
                    MessageBox.Show("Книга добавилась");
                    listBoxBooks.Items.Clear();
                    foreach (Book x in bdb.Books)
                        listBoxBooks.Items.Add(x.Name + " | " + x.Price + " | " + x.Author);
                    textBoxBookName.Text = "";
                    textBoxBookPrice.Text = "";
                    richTextBoxBookDescription.Text = "";
                    textBoxBookAuthor.Text = "";
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                }
                else
                    MessageBox.Show("Некорректная цена!");
            }
            else
            {
                if (textBoxBookName.Text == "")
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Black;
                if (textBoxBookPrice.Text == "")
                    label6.ForeColor = Color.Red;
                else
                    label6.ForeColor = Color.Black;
                if (richTextBoxBookDescription.Text == "")
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Black;
                if (textBoxBookAuthor.Text == "")
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;
            }
        }
        private void buttonFinalChange_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxBookPrice.Text, out int k))
            {
                Book change = bdb.Books.Where(x => x.Name + " | " + x.Price + " | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
                if (textBoxBookName.Text == change.Name && textBoxBookPrice.Text == Convert.ToString(change.Price) && richTextBoxBookDescription.Text == change.Description && textBoxBookAuthor.Text == change.Author)
                    labelInfo.Visible = true;

                else
                {
                    buttonFinalChange.Enabled = false;
                    button2.Enabled = false;
                    labelInfo.Visible = true;
                    change.Name = textBoxBookName.Text;
                    change.Price = Convert.ToInt32(k);
                    change.Description = richTextBoxBookDescription.Text;
                    change.Author = textBoxBookAuthor.Text;
                    bdb.SaveChanges();
                    listBoxBooks.Items.Clear();
                    foreach (Book book in bdb.Books)
                        listBoxBooks.Items.Add(book.Name + " | " + book.Price + " | " + book.Author);
                    textBoxBookName.Text = "";
                    textBoxBookPrice.Text = "";
                    richTextBoxBookDescription.Text = "";
                    textBoxBookAuthor.Text = "";
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                }
            }
            else
                MessageBox.Show("Некорректная цена!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить книгу из библиотеки навсегда?\nКнига больше не будет доступна в каталоге.", "Удаление книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    button2.Enabled = false;
                    buttonFinalChange.Enabled = false;
                    Book delete = bdb.Books.Where(x => x.Name + " | " + x.Price + " | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
                    bdb.Books.Remove(delete);
                    bdb.SaveChanges();
                    listBoxBooks.Items.Clear();
                    foreach (Book book in bdb.Books)
                        listBoxBooks.Items.Add(book.Name + " | " + book.Price + " | " + book.Author);
                    textBoxBookName.Text = "";
                    textBoxBookPrice.Text = "";
                    richTextBoxBookDescription.Text = "";
                    textBoxBookAuthor.Text = "";
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                }
                else
                    return;
            }
            catch
            { 
                MessageBox.Show("Произошла ошибка!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (Context bdb = new Context())
            {
                Book change = bdb.Books.Where(x => x.Name + " | " + x.Price + " | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
                if (change != null)
                {
                    openFileDialog1.ShowDialog();
                    byte[] imagefile = File.ReadAllBytes(openFileDialog1.FileName);
                    change.Photo = imagefile;
                    bdb.SaveChanges();
                }
            }
        }
        private void Library_Load(object sender, EventArgs e)
        {
            foreach (Book book in bdb.Books)
                listBoxBooks.Items.Add(book.Name + " | " + book.Price + " | " + book.Author);
        }
        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book change = bdb.Books.Where(x => x.Name + " | " + x.Price + " | " + x.Author == listBoxBooks.SelectedItem).FirstOrDefault();
            if (change != null)
            {
                textBoxBookName.Text = change.Name;
                textBoxBookPrice.Text = Convert.ToString(change.Price);
                richTextBoxBookDescription.Text = change.Description;
                textBoxBookAuthor.Text = change.Author;
                buttonFinalChange.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
            }
        }
    }
}
