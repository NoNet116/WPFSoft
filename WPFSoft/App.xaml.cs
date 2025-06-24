using DAL.Repositories;
using System.Windows;
using Unity;
using WPFSoft.Models;
using WPFSoft.ViewModels;
using WPFSoft.Views;

namespace WPFSoft
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeesViewModel, EmployeesViewModel>();
            container.Resolve<EmployeesView>().Show();

        }
    }
}
