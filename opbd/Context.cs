using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;

namespace opbd
{
    class Context : DbContext
    {
        public Context() : base("DbConnection") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Buy> Buys { get; set; }
        public DbSet<User> Users { get; set; }
        public static string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }
        public static string hiString = "Войти";
        public static string hiRole = "";
        public static string Email;
        public static int Balance;
        public static int ID;
        public static bool IsRePass = false;
    }
}
