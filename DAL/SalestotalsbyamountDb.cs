using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
namespace DAL
{
    public class SalestotalsbyamountDb
    {
        MilkCRMv0_12Entities db;
        public SalestotalsbyamountDb()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<Sales_Totals_by_Amount> GetAll()
        {
            return db.Sales_Totals_by_Amounts.ToList();
        }
        public Sales_Totals_by_Amount GetById(int Id) 
        {
            return db.Sales_Totals_by_Amounts.Find(Id);
        }
        public void Insert(Sales_Totals_by_Amount cust)
        {

            db.Sales_Totals_by_Amounts.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Sales_Totals_by_Amount cust = db.Sales_Totals_by_Amounts.Find(Id);
            db.Sales_Totals_by_Amounts.Remove(cust);
            Save();
        }
        public void Update(Sales_Totals_by_Amount cust)
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