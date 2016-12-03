using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BOL;
namespace DAL
{
    public class UserAccountsDAL
    {
        MilkCRMv0_12Entities entities;
        public UserAccountsDAL()
        {
            entities = new MilkCRMv0_12Entities();   
        }

        public IEnumerable<UserAccount> GetAll()
        {
            return entities.UserAccounts.ToList();

        }
        public UserAccount GetById(int Id)
        {
            UserAccount p = entities.UserAccounts.Find(Id);
            return p;
        }

        public void Delete(int Id)
        {
            UserAccount p = entities.UserAccounts.Find(Id);
            entities.UserAccounts.Remove(p);
            Save();
        }
        public void Insert(UserAccount ua)
        {
            entities.UserAccounts.Add(ua);
            Save();
        }
        public void Update(UserAccount ua)
        {
            entities.Entry(ua).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            entities.SaveChanges();
        }
        
     }
}