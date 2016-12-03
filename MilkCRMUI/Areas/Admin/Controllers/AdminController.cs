using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        AdminBLL bll;
        public AdminController()
        {
            bll = new AdminBLL(); 
        }
        // GET: Admin/Admin
       
    }
}