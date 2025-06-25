using DAL.Models;
using DAL.Repositories;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using WPFSoft.Models;

namespace WPFSoft.ViewModels
{
    public class EmployeesViewModel : INotifyPropertyChanged, IEmployeesViewModel
    {
        private readonly IEmployeeRepository _repository;
        private string _filter;
        public ObservableCollection<EmployeeModel> AllEmployees { get; set; } 
        private ICollectionView _employeesView;
        public EmployeesViewModel(IEmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
            LoadData();
        }

        public ICollectionView EmployeesView
        {
            get => _employeesView;
            private set
            {
                _employeesView = value;
                OnPropertyChanged();
            }
        }

        public string Filter
        {
            get => _filter;
            set
            {
                if (_filter != value)
                {
                    _filter = value?.ToLower();
                    OnPropertyChanged();
                    EmployeesView?.Refresh();
                }
            }

            /* Как работает Filter?
            В XAML: <TextBox Text="{Binding Filter, UpdateSourceTrigger=PropertyChanged}" />
            Это означает:
            каждый раз, когда пользователь меняет текст в TextBox, это значение передаётся в свойство Filter во ViewModel.
             */
        }

        private void LoadData()
        {
            var data = _repository.GetAll();
            AllEmployees = new ObservableCollection<EmployeeModel>(Minimapper(data));
            EmployeesView = CollectionViewSource.GetDefaultView(AllEmployees);
            EmployeesView.Filter = FilterPredicate;
            
        }

        private bool FilterPredicate(object item)
        {
            if (item is EmployeeModel emp)
            {
                return string.IsNullOrEmpty(_filter)
                    || emp.FirstName?.ToLower().Contains(_filter) == true
                    || emp.LastName?.ToLower().Contains(_filter) == true;
            }
            return false;
        }

        private IEnumerable<EmployeeModel> Minimapper(IEnumerable<Employee> employees)
        {
            return employees.Select(e => new EmployeeModel
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Age = e.Age,
                CityName = e.CityName
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}
