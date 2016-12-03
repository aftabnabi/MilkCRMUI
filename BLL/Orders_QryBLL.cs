using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using BOL;

namespace BLL
{
    public class Orders_QryBLL
    {
        Orders_QryDAL db;
        public Orders_QryBLL()
        {
            db = new Orders_QryDAL();
        
        }
        public IEnumerable<Orders_Qry> GetAll()
        {
            return db.GetAll();
        }
        public Orders_Qry GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Orders_Qry order)
        {
             db.Insert(order);
        }
        public void Update(Orders_Qry order)
        {
            db.Update(order);
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        ~Orders_QryBLL()
        {
                
        }
    }
}