using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFSoft.Models;
using WPFSoft.ViewModels;

namespace WPFSoft.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        

        IEmployeesViewModel _employeesViewModel;
        IEmployeeViewModel _employeeViewModel;
        public EmployeesView(IEmployeesViewModel employeesViewModel, IEmployeeViewModel employeeViewModel)
        {
            _employeeViewModel = employeeViewModel;
            _employeesViewModel = employeesViewModel;
            InitializeComponent();
            DataContext = _employeesViewModel;
            
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is EmployeeModel employee)
            {
              
                _employeeViewModel.Employee = employee;
                var employeeView = new EmployeeView(_employeeViewModel);

                employeeView.Show();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var item = lview_emp.SelectedItem;
            if (item is EmployeeModel employee)
            {

                _employeeViewModel.Employee = employee;
                var employeeView = new EmployeeView1(_employeeViewModel);
                employeeView.Show();

            }
            else
            {
                Title = "Выберите пользователя";
            }
        }
    }
}
