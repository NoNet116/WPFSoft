using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFSoft.Models;

namespace WPFSoft.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is EmployeeModel employee)
            {
                MessageBox.Show($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
