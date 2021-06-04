using System;
using System.Collections.Generic;

#nullable disable

namespace MedicineApp.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int FirmId { get; set; }
        public bool IsReceipt { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
