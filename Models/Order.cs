using System;
using System.Collections.Generic;

#nullable disable

namespace MedicineApp.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? WorderId { get; set; }

        public virtual Worker Worder { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
