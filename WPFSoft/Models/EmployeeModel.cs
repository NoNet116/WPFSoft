using System;
namespace WPFSoft.Models
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string CityName { get; set; }
    }
}
