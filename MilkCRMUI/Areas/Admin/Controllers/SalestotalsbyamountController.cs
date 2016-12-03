using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class SalestotalsbyamountController : Controller
    {
        AdminBLL bll;
        public SalestotalsbyamountController()
        {
            bll = new AdminBLL();
        }
        // GET: Admin/Salestotalsbyamount
        public ActionResult Index()
        {
            return View(bll.salesamt.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
                return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sales_Totals_by_Amount s)
        {
            if(!ModelState.IsValid)
            return View();
            try
            {
                bll.salesamt.Insert(s);
                TempData["msg"] = "Created successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "couldn't create"+ex.ToString();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            if(!ModelState.IsValid)
                return View();
            Sales_Totals_by_Amount s;
            try
            {
                s = bll.salesamt.GetById(Id);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return View(s);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View(bll.salesamt.GetById(Id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sales_Totals_by_Amount s)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.salesamt.Update(s);
                TempData["msg"] = "Edited Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Edit failed"+ex.ToString();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            if(!ModelState.IsValid)
                return View();
            try
            {
                bll.salesamt.Delete(Id);
                TempData["msg"] = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Deleted failed" +ex.ToString();
            }
            return RedirectToAction("Index");
        }
    }
}