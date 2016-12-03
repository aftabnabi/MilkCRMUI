using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class CustomerBLL
    {
        CustomersDb db;
        public CustomerBLL()
        {
            db = new CustomersDb();
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Customer GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Customer cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Customer cust)
        {
            db.Update(cust);
        }

    }
}