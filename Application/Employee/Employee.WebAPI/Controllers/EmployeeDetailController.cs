using Employee.Core.Models;
using Employee.Service.Interfaces;
using Employee.Service.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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


        [HttpGet]
        [Authorize]
        [Route("api/GetEmployeeDetailsParsed/{id}")]
        public string GetEmployeeDetailParsed(int id)
        {
            var employee = JsonConvert.SerializeObject(_iEmployeeDetailService.GetEmployee(id));
            var finalResult = string.Empty;

            Dictionary<string, string> employeeDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(employee);

            foreach (var detail in employeeDict)
            {
                finalResult += detail.Value + "&";
            }

            return finalResult.TrimEnd('&');
        }


    }
}
