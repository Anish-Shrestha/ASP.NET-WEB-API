using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service.Interfaces
{
    public interface IEmployeeDetailService
    {
        List<EmployeeDetailDto> GetEmployeeDetail();
        EmployeeDetailDto GetEmployee(int id);
    }
}
