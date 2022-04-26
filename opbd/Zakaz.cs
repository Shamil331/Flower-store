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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show(Context.hiRole);
            listBox1.Items.Clear();
            using (Context db = new Context())
            {
                if (Context.hiRole!="Admin")
                {
                  //  MessageBox.Show(Convert.ToString(Context.ID));
                    //foreach (User user in db.Users)
                    //{
                    //    foreach (Buy buy in db.Buys)
                    //    {
                    //        if (user.Id == buy.user_id)
                    //        {

                    //        }
                    //    }
                    //}
                    foreach (Buy buy in db.Buys)
                    {
                        if (Context.ID==buy.user_id)
                        {
                            //MessageBox.Show(Convert.ToString(Context.ID) + " " + Convert.ToString(buy.user_id));
                            listBox1.Items.Add("Книга " + buy.book_name + " стоимостью " + buy.book_price + " рублей. Дата покупки " + buy.date);
                        }
                    }
                }
                else
                {
                    foreach (Buy buy in db.Buys)
                    {
                        listBox1.Items.Add("Книга " + buy.book_name + " стоимостью " + buy.book_price + " рублей. Дата покупки " + buy.date+" Покупатель: "+buy.user_id+" | "+buy.user_login);
                    }
                }
            }
        }
    }
}
