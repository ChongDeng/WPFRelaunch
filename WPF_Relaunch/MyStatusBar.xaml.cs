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

namespace WPF_Relaunch
{
    /// <summary>
    /// Interaction logic for MyStatusBar.xaml
    /// </summary>
    public partial class MyStatusBar : UserControl
    {
        public MyStatusBar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            this.tblCount.Text = tb.Text.Length.ToString();
        }

    }
}
