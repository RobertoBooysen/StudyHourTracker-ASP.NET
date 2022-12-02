using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace PROG6212_POE_Web_Application.Models
{
    public partial class TblRemainingStudyHour
    {
        public int RemainingModulesHoursId { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Self-Study Hours")]
        public int SelfStudyHours { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Number Of Hours")]
        public int NumberOfHours { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Day Of Study")]
        public string DayOfStudy { get; set; }
        [Required(ErrorMessage = "This field is required")]//Error handling so that all fields are filled in(Troeslen & Japikse, 2021)
        [Display(Name = "Remaing Self-Study Hours")]
        public int RemainingStudyHours { get; set; }
        public string Username { get; set; }
    }
}
