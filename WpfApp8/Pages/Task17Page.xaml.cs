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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;

            x = Convert.ToInt32(TbX.Text);
            y = Convert.ToInt32(TbY.Text);  
            z = Convert.ToInt32(TbZ.Text);

            Task17 task17 = new Task17(x, y, z);

            TbA.Text = $"{task17.Exp()}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbZ.Text = string.Empty;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }
    }
}
