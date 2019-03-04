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
    /// Логика взаимодействия для RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                   LibraryDb contex = new LibraryDb();

            if( contex.User.Where(b => b.Login == LogText.Text).Count()==0)
            {
                contex.User.Add(
                    new User
                    {
                        Login = LogText.Text,
                        Passwd = PassText.Text,
                        Name = NameText.Text,
                        surname = SurNamText.Text
                    }

                );
            contex.SaveChanges();
            }
            else
            {
                MessageBox.Show("Такий користувач вже існує", "Eror", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
