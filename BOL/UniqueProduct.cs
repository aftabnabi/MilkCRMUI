using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace BOL
{
    class UniqueProductAttribute : ValidationAttribute
    {
        //
        // Summary:
        //     Validates the specified value with respect to the current validation attribute.
        //
        // Parameters:
        //   value:
        //     The value to validate.
        //
        //   validationContext:
        //     The context information about the validation operation.
        //
        // Returns:
        //     An instance of the System.ComponentModel.DataAnnotations.ValidationResult
        //     class.
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            MilkCRMv0_12Entities ent = new MilkCRMv0_12Entities();
            
            int count = ent.Products.Where(x=>x.ProductName==value.ToString()).Count();
            if(count!=0)
                return new ValidationResult("Exists. this product already exists! try other name");

            return ValidationResult.Success;
        }
    }
}
