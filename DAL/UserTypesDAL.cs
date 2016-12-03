using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;

namespace DAL
{
    public class UserTypesDAL
    {
         MilkCRMv0_12Entities db;
        public UserTypesDAL()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<UserType> GetAll()
        {
            return db.UserTypes.ToList();
        }
        public UserType GetById(int Id) 
        {
            return db.UserTypes.Find(Id);
        }
    }
}