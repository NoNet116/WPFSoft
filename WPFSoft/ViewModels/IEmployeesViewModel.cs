using System.Collections.ObjectModel;
using WPFSoft.Models;

namespace WPFSoft.ViewModels
{
    public interface IEmployeesViewModel
    {
        ObservableCollection<EmployeeModel> AllEmployees { get; set; }
        string Filter { get; set; }
        //string FilterMessage { get; set; }
    }
}
