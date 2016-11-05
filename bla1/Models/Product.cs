using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla1.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Category")]
        public virtual Category Category { get; set; }

        [Required]
        [DisplayName("Price")]
        public float Price { get; set; }

        [Required]
        [DisplayName("Added Date")]
        public DateTime AddedDate { get; set; }
    }
}