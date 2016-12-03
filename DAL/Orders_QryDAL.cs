using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;

namespace DAL
{
    public class Orders_QryDAL
    {
        MilkCRMv0_12Entities db;
        public Orders_QryDAL()
        {
            db = new MilkCRMv0_12Entities();
        }
        public IEnumerable<Orders_Qry> GetAll()
        {
            return db.Orders_Qries.ToList();
        }
        public Orders_Qry GetById(int Id)
        {
            return db.Orders_Qries.Find(Id);
        }
        public void Insert(Orders_Qry oq)
        {
            db.Orders_Qries.Add(oq);
            Save();
        }
        public void Delete(int id)
        {
            db.Orders_Qries.Remove(db.Orders_Qries.Find(id));
            Save();
        }
        public void Update(Orders_Qry oq)
        {
            db.Entry(oq).State = EntityState.Modified;
            Save();
        }

        private void Save()
        {
            db.SaveChanges();
        }
        ~Orders_QryDAL()
        {
                
        }
    }
}