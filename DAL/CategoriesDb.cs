using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
namespace DAL
{
    public class CategoriesDb
    {

        MilkCRMv0_12Entities db;
        public CategoriesDb()
        {
            db = new MilkCRMv0_12Entities();
        }
        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public Category GetById(int Id) 
        {
            return db.Categories.Find(Id);
        }
        public void Insert(Category cust)
        {

            db.Categories.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Category cust = db.Categories.Find(Id);
            db.Categories.Remove(cust);
            Save();
        }
        public void Update(Category cust)
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