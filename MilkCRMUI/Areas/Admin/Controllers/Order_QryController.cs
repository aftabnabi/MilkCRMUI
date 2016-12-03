using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class Order_QryController : Controller
    {

        AdminBLL bll;
        public Order_QryController()
        {
            bll = new AdminBLL();
        }
        // GET: Admin/Order_Qry
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category c)
        {
            return View();
        }
        public ActionResult Details(int Id)
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Edit(Category c)
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
            return View();
        }
    }
}