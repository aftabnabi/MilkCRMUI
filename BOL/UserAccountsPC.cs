using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public partial class UserAccounts
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        
        [Display(Name="Password")]
        [Required]
        public string Password { get; set; }
        
        [Required]
        [Display(Name="Confirm Password")]

        public string ConfirmPassword{get;set;}
    }
}