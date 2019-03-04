using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для EnterForm.xaml
    /// </summary>
    public partial class EnterForm : Window
    {
        int? MyId = null;
        public EnterForm(ref int? MyId)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LibraryDb contex = new LibraryDb();
            var Usr = contex.User.Where(b =>b.Login == LoginTextBox.Text).ToList();
            if(Usr.Count()!=0)
            {
                if(Usr[0]. Passwd==PasswdTextBox.Text)
                {
                    MyId = Usr[0].Id;
                }
            }
        }
    }
}
