using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class SalesbycategoriesController : Controller
    {
        AdminBLL bll;
        public SalesbycategoriesController()
        {
            bll = new AdminBLL();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sales_by_Categories s)
        {
         if(!ModelState.IsValid)
             return View();

         try
         {
             bll.salescat.Insert(s);
             TempData["msg"] = "created successfully.";
         }
         catch (Exception ex)
         {

             TempData["msg"] = "failed to create "+ex.ToString();
         }
         return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            if (!ModelState.IsValid)
                return View();
            Sales_by_Categories s=null;
            try
            {
                s = bll.salescat.GetById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(s);
        }
        public ActionResult Edit(int Id)
        {
            return View(bll.salescat.GetById(Id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sales_by_Categories s)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.salescat.Update(s);
                TempData["msg"] = "Updated Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "failed to update" + ex.ToString();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete (int Id)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.salescat.Delete(Id);
                TempData["msg"] = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "couldnt delete" + ex.ToString();
            }
            return RedirectToAction("Index");
        }
        // GET: Admin/Salesbycateories
        public ActionResult Index()
        {
            var s = bll.salescat.GetAll();
            return View(s.ToList());
        }
    }
}