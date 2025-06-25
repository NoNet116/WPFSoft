using System.Windows;
using WPFSoft.ViewModels;

namespace WPFSoft.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Window
    {
        IEmployeeViewModel _employeViewModel;
        public EmployeeView(IEmployeeViewModel employesViewModel)
        {
            _employeViewModel = employesViewModel;
            InitializeComponent();
            DataContext = _employeViewModel;
        }
    }
}
