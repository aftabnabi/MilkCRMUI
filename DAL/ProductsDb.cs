using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BOL;
namespace DAL
{
    public class ProductsDb
    {
        MilkCRMv0_12Entities entities;
        public ProductsDb()
        {
            entities = new MilkCRMv0_12Entities();   
        }

        public IEnumerable<Product> GetAll()
        {
            return entities.Products.ToList();

        }
        public Product GetById(int Id)
        {
            Product p = entities.Products.Find(Id);
            return p;
        }

        public void Delete(int Id)
        {
            Product p = entities.Products.Find(Id);
            entities.Products.Remove(p);
            Save();
        }
        public void Insert(Product product)
        {
            entities.Products.Add(product);
            Save();
        }
        public void Update(Product prod)
        {
            entities.Entry(prod).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            entities.SaveChanges();
        }
        
     }
}