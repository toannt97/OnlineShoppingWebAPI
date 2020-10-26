using System;
using System.Collections.Generic;

namespace OnlineShoppingWebAPI.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
