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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task6 task6 = new Task6(false, false, true);

            TbA.Text = $"a) {task6.ExpA()}";
            TbB.Text = $"b) {task6.ExpB()}";
            TbC.Text = $"c) {task6.ExpC()}";
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task7Page());
        }
    }
}
