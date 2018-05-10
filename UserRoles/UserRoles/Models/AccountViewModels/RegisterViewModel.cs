using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserRoles.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their email address.
        public bool EmailConfirmed { get; set; }

        // Summary:
        //     Gets or sets a telephone number for the user.
        public string PhoneNumber { get; set; }

        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their telephone address.
        public bool PhoneNumberConfirmed { get; set; }
    }
}
