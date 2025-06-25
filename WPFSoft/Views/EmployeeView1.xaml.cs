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
using System.Windows.Shapes;
using WPFSoft.ViewModels;

namespace WPFSoft.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeView1.xaml
    /// </summary>
    public partial class EmployeeView1 : Window
    {
        public EmployeeView1(IEmployeeViewModel employeesViewModel)
        {
            InitializeComponent();
            DataContext = employeesViewModel;
        }
    }
}
