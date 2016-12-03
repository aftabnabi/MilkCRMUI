using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class SalestotalsbyamountBLL
    {
        SalestotalsbyamountDb db;
        public SalestotalsbyamountBLL()
        {
            db = new SalestotalsbyamountDb();
        }

        public IEnumerable<Sales_Totals_by_Amount> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Sales_Totals_by_Amount GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Sales_Totals_by_Amount cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Sales_Totals_by_Amount cust)
        {
            db.Update(cust);
        }

    }
}