using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla1.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Addresss")]
        public string Address { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new List<Product>();
        }
    }
}