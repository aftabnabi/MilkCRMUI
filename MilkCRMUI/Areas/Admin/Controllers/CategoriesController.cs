using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using BLL;
using BOL;

namespace MilkCRMUI.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesBLL bll;
        // GET: Admin/Categories
        public CategoriesController()
        {
            bll = new CategoriesBLL();
        }

        public ActionResult Index()
        {

                var c= bll.GetAll();
            //ViewBag.Path=
            return View(c.ToList());
        }
        public FileContentResult myAction(byte[] imagearray)
        {
           
            return new FileContentResult(imagearray, "Image/jpeg");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            int le = Request.Files[0].ContentLength;
            string fn = Request.Files[0].FileName;
            Stream pic = Request.Files[0].InputStream;
            byte[] photo = null;
            using (var binr = new BinaryReader(pic))
            {
                photo = binr.ReadBytes(le);

            }
            cat.Picture = photo;
            bll.Insert(cat);
            return View();
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            Category cat = new Category();
            cat = bll.GetById(Id);
            Category cat2 = new Category { 
                CategoryID=cat.CategoryID,
                CategoryName=cat.CategoryName,
                Description=cat.Description,
                Picture=cat.Picture//=String.Format("data:Image/jpeg;base64,{0}",Convert.ToBase64String(cat.Picture));
            };
            ViewBag.Photo = cat.Picture;
            return View(cat2);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Category cat = new Category();
            cat = bll.GetById(Id);
            Category cat2 = new Category
            {
                CategoryID = cat.CategoryID,
                CategoryName = cat.CategoryName,
                Description = cat.Description,
                Picture = cat.Picture//=String.Format("data:Image/jpeg;base64,{0}",Convert.ToBase64String(cat.Picture));
            };
            ViewBag.Photo = cat.Picture;
            return View(cat2);
        }

        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            try
            {
                int len = Request.Files[0].ContentLength;
                string fn = Request.Files[0].FileName;
                string type = Request.Files[0].ContentType;
                Stream str = Request.Files[0].InputStream;
                byte[] ph = null;
                using (var binr = new BinaryReader(str))
                {
                    ph = binr.ReadBytes(len);
                }
                cat.Picture = ph;
                
                
                bll.Update(cat);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}