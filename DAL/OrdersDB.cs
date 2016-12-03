using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data;
using System.Data.Entity;
namespace DAL
{
    
    public class OrdersDB
    {
        MilkCRMv0_12Entities db;
        public OrdersDB()
        {
            db = new BOL.MilkCRMv0_12Entities();
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders.ToList();
        }
        public Order GetById(int Id)
        {
            return db.Orders.Find(Id);
        }
        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
            Save();
        }
        public void Insert(Order order)
        {
            db.Orders.Add(order);
            Save();
        }
        public  void Delete(int Id)
        {
            Order _findorder = db.Orders.Find(Id);
            db.Orders.Remove(_findorder);
            Save();
        }
        private void Save()
        {
            db.SaveChanges();
        }
        ~OrdersDB()
        {
                
        }
    }
}