using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using BOL;

namespace BLL
{
    public class UserTypesBLL
    {
        UserTypesDAL db;
        public UserTypesBLL()
        {
            db = new UserTypesDAL();
        
        }
        public IEnumerable<UserType> GetAll()
        {
            return db.GetAll();
        }
        public UserType GetById(int Id)
        {
            return db.GetById(Id);
        }
        //public void Insert(Order order)
        //{
        //     db.Insert(order);
        //}
        //public void Update(Order order)
        //{
        //    db.Update(order);
        //}
        //public void Delete(int Id)
        //{
        //    db.Delete(Id);
        //}
        //~OrderBLL()
        //{
                
        //}
    }
}