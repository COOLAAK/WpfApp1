using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LibraryDb : DbContext
    {
        public LibraryDb()
            : base("name=LibraryDb")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Inform> Inform { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
