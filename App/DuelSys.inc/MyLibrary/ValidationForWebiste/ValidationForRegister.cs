using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyLibrary.ValidationForWebiste
{
    public class ValidationForRegister
    {
        [Required(ErrorMessage = "Check Name Again")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Check Email Again")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Check Password Again")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Check Password Again")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Check Phone Again")]
        public string Phone { get; set; }
    }
}
