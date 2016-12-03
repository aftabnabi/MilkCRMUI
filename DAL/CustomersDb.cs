using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
using System.Diagnostics;
using System.Data.Entity.Validation;
namespace DAL
{
    public class CustomersDb
    {
        MilkCRMv0_12Entities db;
        public CustomersDb()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customers.ToList();
        }
        public Customer GetById(int Id) 
        {
            return db.Customers.Find(Id);
        }
        public void Insert(Customer cust)
        {

            db.Customers.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Customer cust = db.Customers.Find(Id);
            db.Customers.Remove(cust);
            Save();
        }
        public void Update(Customer cust)
        {
            db.Entry(cust).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}