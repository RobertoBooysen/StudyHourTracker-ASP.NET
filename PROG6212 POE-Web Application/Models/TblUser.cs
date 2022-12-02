using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace PROG6212_POE_Web_Application.Models
{
    public partial class TblUser
    {
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Username")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
