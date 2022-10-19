using System;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username too long!!")] 
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
