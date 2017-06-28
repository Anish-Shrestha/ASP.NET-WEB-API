using Employee.Core.Models;
using Employee.Data.Repositiories;
using Employee.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service.Services
{
    public class EmployeeDetailService: IEmployeeDetailService
    {
        private EmployeeDetailRepository _employeeDetailRepository;

        public EmployeeDetailService()
        {
            _employeeDetailRepository = new EmployeeDetailRepository();
        }

        public EmployeeDetailDto GetEmployee(int id)
        {
            return _employeeDetailRepository.GetEmployee(id);
        }

        public List<EmployeeDetailDto> GetEmployeeDetail()
        {
            return _employeeDetailRepository.GetEmployeeDetail();
        }
    }
}
