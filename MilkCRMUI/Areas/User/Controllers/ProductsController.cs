using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace MilkCRMUI.Areas.User.Controllers
{
    public class ProductsController : Controller
    {
        ProductsBLL db;
        public ProductsController()
        {
            db = new ProductsBLL();
        }
        // GET: User/Products
        public ActionResult Index()
        {
            var products = db.GetAll();
            return View(products.ToList());
        }
    }
}