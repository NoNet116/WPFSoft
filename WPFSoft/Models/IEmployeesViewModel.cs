using DAL.Models;
using System.Collections.ObjectModel;

namespace WPFSoft.Models
{
    public interface IEmployeesViewModel
    {
        ObservableCollection<EmployeeModel> AllEmployees { get; set; }
        string Filter { get; set; }
        //string FilterMessage { get; set; }
    }
}
