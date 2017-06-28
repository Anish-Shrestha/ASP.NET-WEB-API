using Employee.WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

           
            return View();
        }

        public ActionResult EmployeeDetail() {

            ViewBag.Title = "Employee Detail";
            return View();
        }
    }
}
