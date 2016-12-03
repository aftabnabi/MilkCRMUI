using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class EmployeesController : Controller
    {
        AdminBLL bll;
        public EmployeesController()
        {
            bll = new AdminBLL();
        }
        // GET: Admin/Employees
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            return View();
        }
        public ActionResult Details(int Id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee   emp)
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
            return View();
        }
    }
}