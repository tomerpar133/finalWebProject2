using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bla1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
    }
}