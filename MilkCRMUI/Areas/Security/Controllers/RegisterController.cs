using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace MilkCRMUI.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        UserAccountsBLL bll;
        public RegisterController()
        {
            bll = new UserAccountsBLL();
        }
        // GET: Security/Register
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
        public ActionResult Create(UserAccount ua)
        {
            try
            {
                if(!ModelState.IsValid)
                    return View();
                bll.Insert(ua);
                TempData["msg"] = "Created successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Couldn't create user:" + ex;
                return RedirectToAction("Index");
            }
            
        }
    }
}