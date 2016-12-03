using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class UserAccountsBLL
    {
        UserAccountsDAL db;
        public UserAccountsBLL()
        {
            db = new UserAccountsDAL();
        }
        public IEnumerable<UserAccount> GetAll()
        {
            return db.GetAll().ToList();
        }
        public UserAccount GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(UserAccount cust)
        {

            db.Insert(cust);

        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(UserAccount cust)
        {
            db.Update(cust);
        }
    }
}