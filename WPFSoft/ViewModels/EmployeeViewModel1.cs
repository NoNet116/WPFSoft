using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSoft.Models;

namespace WPFSoft.ViewModels
{
    public class EmployeeViewModel1: IEmployeeViewModel1
    {
        private EmployeeModel _employee;
        public EmployeeModel Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }
    }
}
