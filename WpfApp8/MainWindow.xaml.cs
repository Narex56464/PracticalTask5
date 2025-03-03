using System.Windows;
using WpfApp8.Pages;
using WpfApp8.Servers;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MyFrame;

            MyFrame.Navigate(new MainPage());
        }
    }
}
