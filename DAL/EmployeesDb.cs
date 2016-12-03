using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using System.Data.Entity;
namespace DAL
{
    public class EmployeesDb
    {
        MilkCRMv0_12Entities db;
        public EmployeesDb()
        {
            db = new MilkCRMv0_12Entities();
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees.ToList();
        }
        public Employee GetById(int Id) 
        {
            return db.Employees.Find(Id);
        }
        public void Insert(Employee cust)
        {

            db.Employees.Add(cust);
            Save();
        }
        public void Delete(int Id)
        {
            Employee cust = db.Employees.Find(Id);
            db.Employees.Remove(cust);
            Save();
        }
        public void Update(Employee cust)
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