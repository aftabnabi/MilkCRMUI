using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace MilkCRMUI.Areas.User.Controllers
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
        
    }
}