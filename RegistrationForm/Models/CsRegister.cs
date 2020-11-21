using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class CsRegister
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Age")]
        [Range(18,90)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please Enter Phone No")]
        public int Phoneno { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}