using DAL.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using WPFSoft.Models;

namespace WPFSoft.ViewModels
{
    public class EmployeeViewModel : IEmployeeViewModel, INotifyPropertyChanged
    {
        private EmployeeModel _employee;
        private ObservableCollection<PropertyItem> _employeeProperties;

        public EmployeeModel Employee
        {
            get => _employee;
            set
            {
                _employee = value;
                LoadTable();
                OnPropertyChanged(nameof(Employee));
                LoadEmployeeView();
            }
        }

        public ObservableCollection<PropertyItem> EmployeeProperties
        {
            get => _employeeProperties;
            set
            {
                _employeeProperties = value;
                OnPropertyChanged(nameof(EmployeeProperties));
            }
        }

        private void LoadEmployeeView()
        {
            if (_employee == null) return;

            EmployeeProperties = new ObservableCollection<PropertyItem>
        {
            new PropertyItem { Parameter = "Фамилия", Value = _employee.LastName },
            new PropertyItem { Parameter = "Имя", Value = _employee.FirstName }
            // Добавьте при необходимости другие поля
        };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        private DataTable _employeeTable;

        public DataTable EmployeeTable
        {
            get => _employeeTable;
            set
            {
                _employeeTable = value;
                OnPropertyChanged(nameof(EmployeeTable));
            }
        }

        void LoadTable()
        {
            EmployeeTable = new DataTable();
            EmployeeTable.Columns.Add("Parametrs", typeof(string));
            EmployeeTable.Columns.Add("Values", typeof(string));
            EmployeeTable.Rows.Add("LastName", _employee.LastName);
            EmployeeTable.Rows.Add("FirstName", _employee.FirstName);
            EmployeeTable.Rows.Add("Age", _employee.Age);
            EmployeeTable.Rows.Add("CityName", _employee.CityName);

        }
    }


}
