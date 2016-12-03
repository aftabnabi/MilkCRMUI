using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using System.Web.Security;

namespace MilkCRMUI.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Security/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserAccount ua)
        {
            try
            {
                if (Membership.ValidateUser(ua.Email,ua.Password))
                {
                    FormsAuthentication.SetAuthCookie(ua.Email, false);

                    return RedirectToAction("Index", "Home", new { area = "Common" });
                }
                else
                {
                    TempData["msg"] = "Login failed";
                    return RedirectToAction("Index");
                }
                                }
            catch (Exception ex)
            {
                TempData["msg"] = "Failed to login:" + ex.ToString();
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new { area = "Common" });
        }
    }
}