using System;
using System.Collections.Generic;
using System.Text;
using EMS.Models;

namespace EMS.Business.Interfaces
{
    public interface IEmployerService
    {
        public bool ValidateEmployerName(string employerName);
        public bool SaveEmployerDetail();
        public List<EmployerModel> GetAllEmployerDetail(EmployerModel employerModel);
        public EmployerModel GetEmployerDetailByName(string employerName);
    }
}
