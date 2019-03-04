using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Site
    {
        public int Id { get; set; }
        public string Addres { get; set; }
        public string Name { get; set; }
        public int description { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
