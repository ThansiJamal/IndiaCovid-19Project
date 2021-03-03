﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class User
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = " Please Enter Name")]
        [StringLength(10, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Entered phone format is not valid.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Password must be string and maximum length should be 7")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
    }
}