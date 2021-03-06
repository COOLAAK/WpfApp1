﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int? MyId = null;
        MyId id = new MyId();
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EnterForm dlg = new EnterForm(id);
            dlg.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            RegisterForm dlg = new RegisterForm();
            dlg.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(id.MyRealId.ToString());
        }
    }
}
