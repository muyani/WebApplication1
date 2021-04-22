using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Users
    {
     // [Key, Column(Order = 1)]
     //   [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public String Username { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Fname { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Lname { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]

        public string Dob { get; set; }
        [Required]

        public string ContactNo { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string FullName()
        {
            return this.Fname + " " + this.Lname;
        }
    }
}