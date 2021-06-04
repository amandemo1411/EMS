using System;
using System.Collections.Generic;
using System.Text;
using EMS.Models;

namespace EMS.Business.Interfaces
{
    public interface IEmployeeService
    {
        public bool ValidateEmployeeName(string employeeName);
        public bool ValidateEmployeeName(string employeeName, string employerName);
        public bool SaveEmployeeDetail(EmployeeModel employeeModel);
        public List<EmployeeModel> GetAllEmployeeDetailByEmployer(string employer);
        public EmployeeModel GetEmployeeDetailByName(string employeeName);
    }
}
