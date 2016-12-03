using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
using DAL;

namespace BLL
{
    public class EmployeesBLL
    {
        EmployeesDb db;
        public EmployeesBLL()
        {
            db = new EmployeesDb();
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.GetAll().ToList();
        }
        public Employee GetById(int Id)
        {
            return db.GetById(Id);
        }
        public void Insert(Employee cust)
        {

            db.Insert(cust);
            
        }
        public void Delete(int Id)
        {
            db.Delete(Id);
        }
        public void Update(Employee cust)
        {
            db.Update(cust);
        }

    }
}