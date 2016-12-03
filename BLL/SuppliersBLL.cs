using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class SuppliersBLL
    {
        SuppliersDb db;
        public SuppliersBLL()
        {
            db = new SuppliersDb();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Supplier GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Supplier cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Supplier cust)
        {
            db.Update(cust);
        }

    }
}