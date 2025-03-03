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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y = 10, x = 2;
            
            Task7 task7 = new Task7(x, y);

            TbA.Text = $"a) {task7.ExpA()}";
            TbB.Text = $"b) {task7.ExpB()}";
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task8Page());
        }
    }
}
