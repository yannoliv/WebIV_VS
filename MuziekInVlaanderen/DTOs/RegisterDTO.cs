using System;
using System.ComponentModel.DataAnnotations;

namespace MuziekInVlaanderen.DTOs
{
    public class RegisterDTO : LoginDTO    {
            [Required]
            [StringLength(200)]
            public String FirstName { get; set; }

            [Required]
            [StringLength(250)]
            public String LastName { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

            [Required]
            [Compare("Password")]
            public String PasswordConfirmation { get; set; }
    }
}
