using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    [Authorize]
    public class UserAccountsController : Controller
    {
        UserAccountsBLL bll;
        public UserAccountsController()
        {
            bll = new UserAccountsBLL();
        }
        // GET: Admin/UserAccounts
        public ActionResult Index()
        {
            return View(bll.GetAll().ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            PopulateAccountTypesDropdown();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserAccount ua)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                bll.Insert(ua);
                TempData["msg"] = "Account created successfully";
                return RedirectToAction("Index", "UserAccounts");
            }
        }
        [HttpGet]
        [Route("UserAccounts/Edit/{Id}")]
        public ViewResult Edit(int Id)
        {
            try
            {
                PopulateAccountTypesDropdown();
                UserAccount ua = bll.GetById(Id);
        
                return View(ua);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Edit(UserAccount ua)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PopulateAccountTypesDropdown();
                    bll.Update(ua);
                    TempData["msg"] = "Updated successfully";
                }

                else {
                    TempData["msg"] = "Failed to update";
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
            
        }
        [HttpGet]
        [Route("UserAccounts/Details/{Id}")]
        public ViewResult Details(int Id)
        {
                return View(bll.GetById(Id));
        }
        [Route("UserAccounts/Delete/{Id}")]
        public ActionResult Delete(int Id)
        {
            bll.Delete(Id);
            TempData["msg"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
        public void PopulateAccountTypesDropdown(object selectedAccountTypes = null)
        {
            MilkCRMv0_12Entities entities = new MilkCRMv0_12Entities();
            var ut = entities.UserTypes.Select(s => new { UserTypeId = s.UserTypeId, Description = s.Description});
            ViewBag.UserTypeID = new SelectList(ut, "UserTypeId", "Description", selectedAccountTypes);
        }
    }
}