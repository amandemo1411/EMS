using System;
using System.Collections.Generic;
using System.Text;
using EMS.Models;

namespace BusinessLayer
{
    public interface IEmployerService
    {
        public bool ValidateEmployerName(string employerName);
        public bool SaveEmployerDetail();
        public List<EmployerModel> GetAllEmployerDetail(EmployerModel employerModel);
        public EmployerModel GetEmployerDetailByName(string employerName);
    }
}
