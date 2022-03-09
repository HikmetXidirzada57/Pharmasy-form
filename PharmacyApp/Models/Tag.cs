using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyApp.Models
{
    public partial class Tag
    {
        public Tag()
        {
            Tagtomedicines = new HashSet<Tagtomedicine>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tagtomedicine> Tagtomedicines { get; set; }
    }
}
