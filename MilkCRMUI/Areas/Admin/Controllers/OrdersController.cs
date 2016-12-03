using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        AdminBLL db;
        MilkCRMv0_12Entities ent;
        public OrdersController()
        {
            db = new AdminBLL();
            ent = new MilkCRMv0_12Entities();
        }
        // GET: Admin/Orders
        public ActionResult Index()
        {
            
            return View(db.or.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order o)
        {
            if (ModelState.IsValid) 
            {
                db.or.Insert(o);
                TempData["msg"] = "Created Successfully";
            }
            return RedirectToAction("Index","Orders");
        }
        [HttpGet]
        public ViewResult Edit(int Id)
        {
            return View(db.or.GetById(Id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order o)
        {

            if (ModelState.IsValid) { 
                db.or.Update(o);
            }
            TempData["msg"]="Updated Successfully";
            return RedirectToAction("Index");
        }
        [HttpGet]
        //[Route("Orders/Detail/Id")]
        public ActionResult Details(int Id)
        {
            return View(db.or.GetById(Id));
        }
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            try
            {
                if(ModelState.IsValid)
                db.or.Delete(Id);

                TempData["msg"] = "Deleted Successfully";
            }
            catch (Exception)
            {
                TempData["msg"] = "no";
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}