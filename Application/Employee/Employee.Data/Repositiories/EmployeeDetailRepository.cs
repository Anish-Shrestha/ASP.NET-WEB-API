using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Repositiories
{
    public class EmployeeDetailRepository
    {
        public EmployeeDetailDto GetEmployee(int id)
        {
            using (var dc = new DataContext())
            {
                var employeeDetail = dc.EmployeeDetails.FirstOrDefault(x => x.EmployeeId == id);

                if (employeeDetail == null)
                    return new EmployeeDetailDto();
                    

                return employeeDetail.ToDTO();
            }
        }

        public List<EmployeeDetailDto> GetEmployeeDetail()
        {
            using (var dc = new DataContext())
            {
                var list = dc.EmployeeDetails
                    .OrderByDescending(x => x.EmployeeId)
                    .ToDTO()
                    .ToList();

                return list;
            }
        }
    }

    // extension method
    public static class ContactExtensions
    {
        public static EmployeeDetailDto ToDTO(this Entities.EmployeeDetail entity)
        {
            return new EmployeeDetailDto()
            {
                BirthDate = entity.BirthDate,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                EmployeeId = entity.EmployeeId,
                FirstName = entity.FirstName,
                Gender = entity.Gender,
                HireDate = entity.HireDate,
                LastName = entity.LastName,
                Title = entity.Title
            };
        }

        public static IEnumerable<EmployeeDetailDto> ToDTO(this IEnumerable<Entities.EmployeeDetail> entities)
        {
            return entities.Select(x => new EmployeeDetailDto()
            {
                EmployeeId = x.EmployeeId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                Gender = x.Gender,
                Title = x.Title,
                HireDate = x.HireDate,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate
            });
        }


    }
}

