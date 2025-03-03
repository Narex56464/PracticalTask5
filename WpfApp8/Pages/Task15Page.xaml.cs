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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp8.Servers;
using WpfApp8.Utilits.Tasks;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Tba.Text);

            Task15 task15 = new Task15(a);

            TbA.Text = $"{task15.Exp()}";

            Tba.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task16Page());
        }
    }
}
