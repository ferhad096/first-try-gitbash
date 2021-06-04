using System;
using System.Collections.Generic;

#nullable disable

namespace MedicineApp.Models
{
    public partial class Tag
    {
        public Tag()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
    }
}
