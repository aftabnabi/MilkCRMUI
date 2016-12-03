using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class CategoriesBLL
    {
        CategoriesDb db;
        public CategoriesBLL()
        {
            db = new CategoriesDb();
        }
        public IEnumerable<Category> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Category GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Category cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Category cust)
        {
            db.Update(cust);
        }

    }
}