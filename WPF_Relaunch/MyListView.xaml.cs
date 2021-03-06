﻿using System;
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
    /// Interaction logic for MyListView.xaml
    /// </summary>
    public partial class MyListView : UserControl
    {
        public List<Student> StudentList { get; set; }

        public MyListView()
        {
            InitializeComponent();

            this.StudentList = Student.GetStudents();
            this.DataContext = this;
        }
    }
}
