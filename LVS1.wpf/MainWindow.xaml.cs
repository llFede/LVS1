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
using LVS1.wpf.ViewModels;

namespace LVS1.wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }

        /*
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if ("login".Length > 0)
            {
               
                    Main wndw = new Main();
                    wndw.Show();
                    this.Close();
                
            }
            else

                MessageBox.Show("Проверьте логин или пароль!");
           
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            Reg wndw1 = reg;
            wndw1.Show();
            this.Close();
        }

        private void click_2(object sender, MouseButtonEventArgs e)
        {

        }*/
    }
}
