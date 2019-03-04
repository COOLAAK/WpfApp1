using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Inform
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Xor { get; set; }
        public virtual Account Account { get; set; }
    }
}
