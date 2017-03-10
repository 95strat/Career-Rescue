using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Career_Rescue.Models.ViewModels
{
    public class MemberSignUpView
    {
        [Key]
        public int Member_id { get; set; }
       
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Middle Name(initials)")]
        public string middleName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Birth Date")]
        public string Birth_date { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Experience")]
        public string Experience { get; set; }

        [Display(Name = "Skills")]
        public string Skills { get; set; }

        [Display(Name = "Resume")]
        public string Resume { get; set; }
    }
}