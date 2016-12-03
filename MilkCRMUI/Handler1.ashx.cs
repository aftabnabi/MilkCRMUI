using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using BLL;
namespace MilkCRMUI
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
           // CategoriesBLL bll = new CategoriesBLL();
            MilkCRMv0_12Entities db = new MilkCRMv0_12Entities();

            context.Response.ContentType = "Image/gif";
            var param =context.Request.QueryString[0];
            int id=0;
            byte[] image = null;
            if (param != null && int.TryParse(param, out id))
            { 
                    image=db.Categories.Where(a=>a.CategoryID.Equals(id)).FirstOrDefault().Picture;
            }
            
            
            
            context.Response.BinaryWrite(image);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}