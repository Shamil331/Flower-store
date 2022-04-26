//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace opbd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buy()
        {
            this.User = new HashSet<User>();
            this.Book = new HashSet<Book>();
        }
    
        public int Id { get; set; }
        public int book_id { get; set; }
        public string book_name { get; set; }
        public int book_price { get; set; }
        public int user_id { get; set; }
        public string user_login { get; set; }
        public System.DateTime date { get; set; }
        public Buy(int book_id, string book_name, int book_price, int user_id, string user_login)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.book_price = book_price;
            this.user_id = user_id;
            this.user_login = user_login;
            this.date = DateTime.Now;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Book { get; set; }
    }
}
