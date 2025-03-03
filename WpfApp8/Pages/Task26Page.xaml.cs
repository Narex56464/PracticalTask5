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
    /// Логика взаимодействия для Task26Page.xaml
    /// </summary>
    public partial class Task26Page : Page
    {
        public Task26Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, b;

            x = Convert.ToDouble(Tbx.Text);
            y = Convert.ToDouble(TbY.Text);
            b = Convert.ToDouble(Tbb.Text);

            Task26 task26 = new Task26(x, y, b);

            TbA.Text = $"a) {task26.ExpA()}";
            TbB.Text = $"b) {task26.ExpB()}";

            Tbb.Text = string.Empty;
            Tbx.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task27Page());
        }
    }
}
