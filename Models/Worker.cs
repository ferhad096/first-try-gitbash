using System;
using System.Collections.Generic;

#nullable disable

namespace MedicineApp.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
