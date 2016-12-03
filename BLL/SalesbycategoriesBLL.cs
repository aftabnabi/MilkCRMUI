using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class SalesbycategoriesBLL
    {
        SalesbycategoriesDb db;
        public SalesbycategoriesBLL()
        {
            db = new SalesbycategoriesDb();
        }

        public IEnumerable<Sales_by_Categories> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Sales_by_Categories GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Sales_by_Categories cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Sales_by_Categories cust)
        {
            db.Update(cust);
        }

    }
}