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

namespace f
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BGblackclick(object sender, RoutedEventArgs e)
        {
            window1.Background = Brushes.Black;
        }
        private void BGwhiteclick(object sender, RoutedEventArgs e)
        {
            window1.Background = Brushes.WhiteSmoke;
        }
        private void Switchbg(object sender, RoutedEventArgs e)
        {
            if (window1.Background != Brushes.Black)
                window1.Background = Brushes.Black;
            else
                window1.Background = Brushes.WhiteSmoke;
        }
        private void Infoclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("это очень крутое окно от очень крутого разработчика");
        }
        private void Exitclick(object sender, RoutedEventArgs e)
        {
            window1.Close();
        }
        private void BGinfo(object sender, RoutedEventArgs e)
        {
            status1.Text = "поменять фон";
        }
        private void BGblackinfo(object sender, RoutedEventArgs e)
        {
            status1.Text = "сделать темно";
        }
        private void BGwhiteinfo(object sender, RoutedEventArgs e)
        {
            status1.Text = "сделать светло";
        }
        private void InfoInfo(object sender, RoutedEventArgs e)
        {
            status1.Text = "задоксить разраба";
        }
        private void Closeinfo(object sender, RoutedEventArgs e)
        {
            status1.Text = "выйти ураа";
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
