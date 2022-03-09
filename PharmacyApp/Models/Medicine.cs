using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyApp.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            Orders = new HashSet<Order>();
            Tagtomedicines = new HashSet<Tagtomedicine>();
        }

        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsReceipt { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDaTe { get; set; }
        public int? FirmId { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Tagtomedicine> Tagtomedicines { get; set; }
    }
}
