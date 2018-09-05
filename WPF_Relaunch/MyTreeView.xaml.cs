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
    /// Interaction logic for MyTreeView.xaml
    /// </summary>
    public partial class MyTreeView : UserControl
    {
        public List<Student> StudentList { get; set; }

        public MyTreeView()
        {
            InitializeComponent();

            this.StudentList = Student.GetStudents();
            this.DataContext = this;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var oldValue = e.OldValue;
            var newValue = e.NewValue;

        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            var treeItem = e.OriginalSource as TreeViewItem;
            if (treeItem != null)
            {
                var isExpanded = treeItem.IsExpanded;
                var isSelected = treeItem.IsSelected;
            }
        }

        private void TreeViewItem_Collapsed(object sender, RoutedEventArgs e)
        {
            var treeItem = e.OriginalSource as TreeViewItem;
            if (treeItem != null)
            {
                var isExpanded = treeItem.IsExpanded;
                var isSelected = treeItem.IsSelected;
            }
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            var treeItem = e.OriginalSource as TreeViewItem;
            if (treeItem != null)
            {
                var isExpanded = treeItem.IsExpanded;
                var isSelected = treeItem.IsSelected;
            }
        }

        private void TreeViewItem_Unselected(object sender, RoutedEventArgs e)
        {
            var treeItem = e.OriginalSource as TreeViewItem;
            if (treeItem != null)
            {
                var isExpanded = treeItem.IsExpanded;
                var isSelected = treeItem.IsSelected;
            }
        }
    }

}
