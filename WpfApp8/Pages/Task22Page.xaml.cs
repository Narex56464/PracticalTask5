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
    /// Логика взаимодействия для Task22Page.xaml
    /// </summary>
    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, b;

            x = Convert.ToDouble(Tbx.Text);
            y = Convert.ToDouble(TbY.Text);
            b = Convert.ToDouble(Tbb.Text);
            
            Task22 task22 = new Task22(x, y, b);

            TbA.Text = $"a) {task22.ExpA()}";
            TbB.Text = $"b) {task22.ExpB()}";

            Tbx.Text = string.Empty;
            TbY.Text = string.Empty;
            Tbb.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task23Page());
        }
    }
}
