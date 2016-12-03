using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
namespace DAL
{
    public class SuppliersDb
    {
        MilkCRMv0_12Entities db;
        public SuppliersDb()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }
        public Supplier GetById(int Id) 
        {
            return db.Suppliers.Find(Id);
        }
        public void Insert(Supplier cust)
        {

            db.Suppliers.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Supplier cust = db.Suppliers.Find(Id);
            db.Suppliers.Remove(cust);
            Save();
        }
        public void Update(Supplier cust)
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