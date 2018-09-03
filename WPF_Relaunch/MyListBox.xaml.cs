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
    /// Interaction logic for MyListBox.xaml
    /// </summary>
    public partial class MyListBox : UserControl
    {
        public List<Student> StudentList { get; set; }

        public MyListBox()
        {
            InitializeComponent();

            this.StudentList = Student.GetStudents();
            this.DataContext = this;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox = (ListBox)sender;
            var selectedItem = listBox.SelectedItem as Student;
            var selectedItems = listBox.SelectedItems;

            MessageBox.Show(string.Format("selectedItem={0}",
                selectedItem.Name));
        }
    }
}
