using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace MilkCRMUI.Areas.Common.Controllers
{
    [AllowAnonymous]
    public class ProductsController : Controller
    {
        ProductsBLL bll;
        public ProductsController()
        {
            bll = new ProductsBLL();
        }
        // GET: Common/Products
        public ActionResult Index()
        {
            
            return View(bll.GetAll());
        }
    }
}