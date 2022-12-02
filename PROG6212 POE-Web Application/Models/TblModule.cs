using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace PROG6212_POE_Web_Application.Models
{
    public partial class TblModule
    {
        public int ModulesId { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Number Of Credits")]
        public int ModuleNumberOfCredits { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Class Hours Weekly")]
        public int ModuleClassHoursPerWeek { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Number Of Weeks")]
        public int NumberOfWeeks { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Start Date")]
        public string StartDate { get; set; }
        [Display(Name = "Self-Study Hours")]
        public int SelfStudyHours { get; set; }
        public string Username { get; set; }
    }
}
