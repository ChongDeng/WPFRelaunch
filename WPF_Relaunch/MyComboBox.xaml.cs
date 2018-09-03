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
    /// Interaction logic for MyComboBox.xaml
    /// </summary>
    public partial class MyComboBox : UserControl
    {
        public List<Student> StudentList { get; set; }

        public MyComboBox()
        {
            InitializeComponent();
            this.StudentList = Student.GetStudents();
            this.DataContext = this;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = (ComboBox)sender;
            var selectedItem = cb.SelectedItem as Student;
            var selectedValue = cb.SelectedValue;
            MessageBox.Show(string.Format("selectedItem={0} selectedValue={1}", 
                selectedItem.Name, selectedValue));

        }
    }
}
