using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;
namespace BLL
{
    public class ProductsBLL
    {

        ProductsDb db;
        public ProductsBLL()
        {
            db = new ProductsDb();
        }
        public IEnumerable<Product> GetAll()
        {
            return db.GetAll();
        }
        public Product GetById(int Id)
        {
            return db.GetById(Id);

        }
        public void Insert(Product product)
        {
            db.Insert(product);
        }
        public void Update(Product product)
        {
            db.Update(product);

        }
        public   void Delete(int Id)
        {
            db.Delete(Id);
        }
        ~ProductsBLL()
        {
                
        }
    }
}