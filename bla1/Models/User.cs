using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla1.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Born")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Addresss")]
        public string Address { get; set; }

        public bool IsAdmin { get; set; }
    }
}