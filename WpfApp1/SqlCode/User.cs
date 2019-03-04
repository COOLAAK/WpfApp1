using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Passwd { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

    }
}
