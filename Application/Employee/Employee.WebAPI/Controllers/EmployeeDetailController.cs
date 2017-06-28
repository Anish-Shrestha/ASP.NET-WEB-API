using Employee.Core.Models;
using Employee.Service.Interfaces;
using Employee.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.WebAPI.Controllers
{
    public class EmployeeDetailController : ApiController
    {
        private IEmployeeDetailService _iEmployeeDetailService;

        public EmployeeDetailController() {

            _iEmployeeDetailService = new EmployeeDetailService();
        }


        [HttpGet]
        [Authorize]
        [Route("api/GetAllEmployeeDetails")]
        public List<EmployeeDetailDto> GetAllEmployeeDetail() {

            return _iEmployeeDetailService.GetEmployeeDetail();
        }

        [HttpGet]
        [Authorize]
        [Route("api/GetEmployeeDetails/{id}")]
        public EmployeeDetailDto GetEmployeeDetails(int id)
        {

            return _iEmployeeDetailService.GetEmployee(id);
        }



    }
}
