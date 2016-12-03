using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using BOL;

namespace BLL
{
    public class OrderBLL
    {
        OrdersDB db;
        public OrderBLL()
        {
            db = new OrdersDB();
        
        }
        public IEnumerable<Order> GetAll()
        {
            return db.GetAll();
        }
        public Order GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Order order)
        {
             db.Insert(order);
        }
        public void Update(Order order)
        {
            db.Update(order);
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        ~OrderBLL()
        {
                
        }
    }
}