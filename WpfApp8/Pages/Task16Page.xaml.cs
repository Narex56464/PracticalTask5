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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;

            x = Convert.ToInt32(TbX.Text);
            y = Convert.ToInt32(TbY.Text);
            z = Convert.ToInt32(TbZ.Text);  

            Task16 task16 = new Task16(x, y, z);

            TbA.Text = $"{task16.Exp()}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbZ.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task17Page());
        }
    }
}
