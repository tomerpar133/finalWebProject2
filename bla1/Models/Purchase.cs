using System.Collections.Generic;

namespace bla1.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}