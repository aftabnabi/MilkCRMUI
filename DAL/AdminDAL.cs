using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
namespace DAL
{
    public class AdminDAL
    {

        public CategoriesDb categoriesDb { get; set; }
        public CustomersDb customersDb { get; set; }
        public EmployeesDb employeesDb { get; set; }
        public OrdersDB ordersDB { get; set; }
        public Orders_QryDAL orders_QryDAL { get; set; }
        public ProductsDb productsDb { get; set; }
        public SalesbycategoriesDb salesbycategoriesDb { get; set; }
        public SalestotalsbyamountDb salestotalsbyamountDb { get; set; }

        public AdminDAL()
        {
            categoriesDb = new CategoriesDb();
            customersDb = new CustomersDb();
            employeesDb = new EmployeesDb();
            ordersDB = new OrdersDB();
            orders_QryDAL = new Orders_QryDAL();
            productsDb = new ProductsDb();
            productsDb = new ProductsDb();
            salesbycategoriesDb = new SalesbycategoriesDb();
            salestotalsbyamountDb = new SalestotalsbyamountDb();
        }
    }
}