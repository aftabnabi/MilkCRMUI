using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class AdminBLL
    {
        public CategoriesBLL ca { get; set; }
        public CustomerBLL cu { get; set; }
        public EmployeesBLL em { get; set; }
        public OrderBLL or { get; set; }
        public Orders_QryBLL oq { get; set; }
        public ProductsBLL pb { get; set; }
        public SalesbycategoriesBLL salescat { get; set; }
        public SalestotalsbyamountBLL salesamt { get; set; }
        public SecurityBLL sec { get; set; }
        public SuppliersBLL spl { get; set; }
        public AdminBLL()
        {
            ca = new CategoriesBLL();
            cu = new CustomerBLL();
            em = new EmployeesBLL();
            or = new OrderBLL();
            oq = new Orders_QryBLL();
            pb = new ProductsBLL();
            salescat = new SalesbycategoriesBLL();
            salesamt = new SalestotalsbyamountBLL();
            sec = new SecurityBLL();
            spl = new SuppliersBLL();
        }
    }
}