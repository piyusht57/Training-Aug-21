using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Prescription
    {
        public Prescription()
        {
            Drug = new HashSet<Drug>();
        }

        public int PreId { get; set; }
        public DateTime? PreDate { get; set; }
        public int? PatId { get; set; }
        public int? DocId { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Pat { get; set; }
        public virtual ICollection<Drug> Drug { get; set; }
    }
}
