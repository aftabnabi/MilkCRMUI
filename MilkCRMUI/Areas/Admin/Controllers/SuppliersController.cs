using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class SuppliersController : Controller
    {
        AdminBLL bll;
        // GET: Admin/Suppliers
        public SuppliersController ()
	    {
            bll = new AdminBLL();
	    }
        public ActionResult Index()
        {
            var s = bll.spl.GetAll();
            return View(s.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Supplier s)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.spl.Insert(s);
                TempData["msg"] = "Created Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Created Successfully" + ex.ToString();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                return View(bll.spl.GetById(Id));
            }
            catch (Exception ex)
            {
                return View(ex.ToString());
            }
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Supplier s)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.spl.Update(s);
                TempData["msg"] = "Edited successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Edited failed"+ex.ToString();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.spl.Delete(Id);
                TempData["msg"] = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Deleted Successfully"+ex.ToString();
            }
            return RedirectToAction("Index");
        }
    }
}