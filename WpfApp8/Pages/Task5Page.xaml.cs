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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Tba.Text);
            int b = Convert.ToInt32(Tbb.Text);

            Task5 task5 = new Task5(a, b);

            TbA.Text = $"{task5.Exp()}";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task6Page());
        }
    }
}
