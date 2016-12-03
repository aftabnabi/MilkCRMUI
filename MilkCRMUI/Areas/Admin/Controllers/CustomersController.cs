using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace MilkCRMUI.Areas.Admin.Controllers
{
    
    public class CustomersController : Controller
    {
        AdminBLL bll;
        public CustomersController()
        {
            bll = new AdminBLL();
        }
        // GET: Admin/Customers
        public ActionResult Index()
        {
            var cust = bll.cu.GetAll();
            return View(cust);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var cust = bll.cu.GetById(Id);
            return View(cust);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)   
        {
            bll.cu.Update(c);
            TempData["msg"] = "Edited Successfully";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            
            return View(bll.cu.GetById(Id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer c)
        {
            bll.cu.Insert(c);
            TempData["msg"] = "Created Successfully.";
            return RedirectToAction("Index") ;
        }
       
        public ActionResult Delete(int Id)
        {
            bll.cu.Delete(Id);
            TempData["msg"] = "Deleted successfully.";
            return RedirectToAction("Index");
        }

    }
}