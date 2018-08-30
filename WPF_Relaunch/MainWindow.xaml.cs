using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Relaunch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void SCUT_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update Data Success!");
        }

        int count = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            var repeatBtn = (RepeatButton)sender;
            repeatBtn.Content = string.Format("RepeatButton{0}", count);
        }
    }
}
