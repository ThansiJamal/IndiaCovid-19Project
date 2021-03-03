using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter password ")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Must contain at least one number and one uppercase and lowercase letter, and at least 4 or more characters")]
        public string Password { get; set; }
    }
}