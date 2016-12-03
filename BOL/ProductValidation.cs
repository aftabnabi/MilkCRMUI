using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOL
{
    public class ProductValidation
    {
        [Required]
        [UniqueProduct]
        [Display(Name="Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name="Quantity per unit:")]
        public string QuantityPerUnit { get; set; }
    }
    [MetadataType(typeof(ProductValidation))]
    public partial class Product
    { }
}