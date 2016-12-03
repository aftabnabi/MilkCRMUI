using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
namespace DAL
{
    public class SalesbycategoriesDb
    {
        MilkCRMv0_12Entities db;
        public SalesbycategoriesDb()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<Sales_by_Categories> GetAll()
        {
            return db.Sales_by_Categories1.ToList();
        }
        public Sales_by_Categories GetById(int CategoryId) 
        {
            return db.Sales_by_Categories1.Find(CategoryId);
        }
        public void Insert(Sales_by_Categories cust)
        {

            db.Sales_by_Categories1.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Sales_by_Categories cust = db.Sales_by_Categories1.Find(Id);
            db.Sales_by_Categories1.Remove(cust);
            Save();
        }
        public void Update(Sales_by_Categories cust)
        {
            db.Entry(cust).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();    
        }
    }
}