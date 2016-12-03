using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace MilkCRMUI.Areas.Admin.Controllers
{
 [Authorize]
    public class ProductsController : Controller
    {
        AdminBLL db;
        MilkCRMv0_12Entities entities;
        public ProductsController()
        {
            db = new AdminBLL();
            entities = new MilkCRMv0_12Entities();
        }
        // GET: Common/Products
        public ActionResult Index()
        {
            return View(db.pb.GetAll());
        }
     [Authorize(Roles="1")]   
     [HttpGet]
        public ActionResult Create()
        {
            PopulateSuppliersDropdown();
            PopulateCategoriesDropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            
             db.pb.Insert(product);
             TempData["msg"] = "Created Successfully";
             return RedirectToAction("Index");

        }
        public ActionResult Delete(int Id)
        {
            try
            {
                db.pb.Delete(Id);
                TempData["msg"] = "Deleted Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["msg"] = " Couldn't be deleted" + ex.ToString();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Details(int Id)
        {
               try
                {
                   return View(db.pb.GetById(Id));
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            
        }
        [HttpGet]

        public ViewResult Edit(int Id)
        {
            Product p = db.pb.GetById(Id);


            return View(p);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            if (ModelState.IsValid) { 
                db.pb.Update(p);

                TempData["msg"] = "Record has been saved successfuly.";
            }
            return RedirectToAction("Index");
        }
        public void PopulateSuppliersDropdown(object selectedSuppliers=null)
        {
            MilkCRMv0_12Entities entities = new MilkCRMv0_12Entities();
            var sup = entities.Suppliers.Select(s => new { SupplierID = s.SupplierID, CompanyName = s.CompanyName });
            ViewBag.SupplierID = new SelectList(sup, "SupplierID", "CompanyName", selectedSuppliers);
        }
        public void PopulateCategoriesDropdown(object selectedCategories=null)
        {
            MilkCRMv0_12Entities entities = new MilkCRMv0_12Entities();
            var ent = entities.Categories.Select(s => new { CategoryID = s.CategoryID, CategoryName = s.CategoryName });
            ViewBag.CategoryID = new SelectList(ent, "CategoryID", "CategoryName", "selectedCategories");
        }
    }
}